using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Linq;
using System.Data.Linq;
using AlliedMods.SourcePawn;
using Mono.Cxxi;

namespace AlliedMods.SourceMod {

	public class NativeInfo
	{
		public NativeInfo(string name, Func<IntPtr, IntPtr, int> func)
		{
			Name = name;
			Function = func;
			Handle = GCHandle.Alloc(Function, GCHandleType.Pinned);
		}

		unsafe public NativeInfo(string name, Func<IPluginContext, int[], int> func)
			: this(name, (IntPtr pluginContextPtr, IntPtr argumentsPtr) => {
				int *args = (int *)argumentsPtr;
				int[] arguments = new int[args[0]];
				for (int i = 1; i <= arguments.Length; i++) {
					arguments[i - 1] = args[i];
				}

				var pc = new IPluginContext(new CppInstancePtr(pluginContextPtr));
				return func(pc, arguments);
			})
		{
		}

		private GCHandle Handle { get; set; }
		public string Name { get; set; }
		public Func<IntPtr, IntPtr, int> Function { get; set; }

	}

	unsafe public partial class IShareSys : ICppObject {

		public void AddNatives(NativeInfo[] info)
		{
			AddNatives(Core.Extension, info);
		}
		public void AddNatives(string name, Func<IntPtr, IntPtr, int> func)
		{
			AddNatives(Core.Extension, name, func);
		}
		public void AddNatives(string name, Func<IPluginContext, int[], int> func)
		{
			AddNatives(Core.Extension, name, func);
		}
		public void AddNatives(Type type)
		{
			AddNatives(Core.Extension, type);
		}

		public void AddNatives(SourceMod.IExtension myself, NativeInfo[] info)
		{
			sp_nativeinfo_s[] natives = new sp_nativeinfo_s[info.Length + 1];
			for (int i = 0; i < info.Length ; i++) {
				natives[i] = new sp_nativeinfo_s(info[i].Name, Marshal.GetFunctionPointerForDelegate(info[i].Function));
			}
			AddNatives(myself, natives);
		}
		public void AddNatives(SourceMod.IExtension myself, NativeInfo info)
		{
			AddNatives(myself, new NativeInfo[] { info });
		}
		public void AddNatives(SourceMod.IExtension myself, string name, Func<IntPtr, IntPtr, int> func)
		{
			AddNatives(myself, new NativeInfo(name, func));
		}
		public void AddNatives(SourceMod.IExtension myself, string name, Func<IPluginContext, int[], int> func)
		{
			AddNatives(myself, new NativeInfo(name, func));
		}
		public void AddNatives(SourceMod.IExtension myself, Type type)
		{
			foreach (var method in type.GetMethods()) {
				var attributes = method.GetCustomAttributes(typeof(SPMethodAttribute), false);
				foreach (SPMethodAttribute attribute in attributes) {
					AddNatives(myself, attribute, method);
				}
			}
		}

		private static string GetString(IPluginContext pluginContext, int i)
		{
			string str;
			if (pluginContext.LocalToString(i, out str) == 0) {
				return str;
			}
			return null;
		}

		private void AddNatives(SourceMod.IExtension myself, SPMethodAttribute attribute, MethodInfo method)
		{
			var @params = method.GetParameters();
			AddNatives(myself, attribute.MethodName ?? method.Name, (IPluginContext pluginContext, int[] arguments) => {
				var methodParams = new object[@params.Length];
				int argumenti = 0;
				for (int i = 0; i < @params.Length; i++) {
					var param = @params[i];
					var type = param.ParameterType;
					if (type == typeof(IPluginContext)) {
						methodParams[i] = pluginContext;
					} else if (type == typeof(string)) {
						methodParams[i] = GetString(pluginContext, arguments[argumenti]);
						argumenti++;
					} else if (type == typeof(int)) {
						methodParams[i] = arguments[argumenti];
						argumenti++;
					} else if (type == typeof(uint)) {
						methodParams[i] = (uint)arguments[argumenti];
						argumenti++;
					} else if (type == typeof(SPBuffer)) {
						methodParams[i] = new SPBuffer(pluginContext, arguments[argumenti]);
						argumenti++;
					} else if (type == typeof(IPluginFunction)) {
						var attributes = param.GetCustomAttributes(typeof(SPMethodAttribute), false);
						if (attributes.Length > 0) {
							var attr = attributes[0] as SPMethodAttribute;
							methodParams[i] = pluginContext.GetFunctionByName(attr.MethodName);
						} else {
							methodParams[i] = pluginContext.GetFunctionById((uint)arguments[argumenti]);
							argumenti++;
						}
					} else if (type.FullName.StartsWith("System.Action") && type.IsGenericType) {
						var callback = typeof(IShareSys).GetMethods(BindingFlags.NonPublic | BindingFlags.Static).Where(m => m.Name == "Callback")
							.Where(m => m.GetGenericArguments().Length == param.ParameterType.GetGenericArguments().Length)
							.First().MakeGenericMethod(param.ParameterType.GetGenericArguments());

						var func = pluginContext.GetFunctionById((uint)arguments[argumenti]);
						argumenti++;
						methodParams[i] = Delegate.CreateDelegate(param.ParameterType, func, callback);
					}
				}
				var ret = method.Invoke(null, methodParams);
				if (method.ReturnType == typeof(int)) {
					return (int)ret;
				} else {
					return 0;
				}
			});
		}

		internal static int GetSP(Type type, object value)
		{
			if (type == typeof(int) || type == typeof(uint)) {
				return (int)value;
			} else if (type == typeof(SPBuffer)) {
				return ((SPBuffer)value).Local;
			}

			return 0;
		}

		private static void Callback(IPluginFunction func, Type[] types, object[] objects)
		{
			int[] args = new int[types.Length];

			for (int i = 0; i < types.Length; i++) {
				args[i] = GetSP(types[i], objects[i]);
			}

			func.CallFunction (args);
		}

		private static void Callback<T1>(IPluginFunction func, T1 value1)
		{
			Callback(func, new [] { typeof(T1) }, new object[] { value1 });
		}
		private static void Callback<T1, T2>(IPluginFunction func, T1 value1, T2 value2)
		{
			Callback(func, new [] { typeof(T1), typeof(T2) }, new object[] { value1, value2 });
		}
		private static void Callback<T1, T2, T3>(IPluginFunction func, T1 value1, T2 value2, T3 value3)
		{
			Callback(func, new [] { typeof(T1), typeof(T2), typeof(T3) }, new object[] { value1, value2, value3 });
		}
		private static void Callback<T1, T2, T3, T4>(IPluginFunction func, T1 value1, T2 value2, T3 value3, T4 value4)
		{
			Callback(func, new [] { typeof(T1), typeof(T2), typeof(T3), typeof(T4) }, new object[] { value1, value2, value3, value4 });
		}
		private static void Callback<T1, T2, T3, T4, T5>(IPluginFunction func, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5)
		{
			Callback(func, new [] { typeof(T1), typeof(T2), typeof(T3), typeof(T4), typeof(T5) }, new object[] { value1, value2, value3, value4, value5 });
		}
		private static void Callback<T1, T2, T3, T4, T5, T6>(IPluginFunction func, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6)
		{
			Callback(func, new [] { typeof(T1), typeof(T2), typeof(T3), typeof(T4), typeof(T5), typeof(T6) }, new object[] { value1, value2, value3, value4, value5, value6 });
		}
		private static void Callback<T1, T2, T3, T4, T5, T6, T7>(IPluginFunction func, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7)
		{
			Callback(func, new [] { typeof(T1), typeof(T2), typeof(T3), typeof(T4), typeof(T5), typeof(T6), typeof(T7) }, new object[] { value1, value2, value3, value4, value5, value6, value7 });
		}
		private static void Callback<T1, T2, T3, T4, T5, T6, T7, T8>(IPluginFunction func, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8)
		{
			Callback(func, new [] { typeof(T1), typeof(T2), typeof(T3), typeof(T4), typeof(T5), typeof(T6), typeof(T7), typeof(T8) }, new object[] { value1, value2, value3, value4, value5, value6, value7, value8 });
		}
	}

}