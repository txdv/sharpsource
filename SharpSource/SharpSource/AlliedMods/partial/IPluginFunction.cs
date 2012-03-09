using System;
using System.Runtime.InteropServices;

namespace AlliedMods.SourcePawn {
	[AttributeUsage (AttributeTargets.All, Inherited = true, AllowMultiple = true)]
	public sealed class SPMethodAttribute : Attribute
	{
		public string MethodName { get; private set; }

		public SPMethodAttribute()
		{
		}

		public SPMethodAttribute(string methodName)
		{
			MethodName = methodName;
		}
	}

	public class SPBuffer
	{
		public int Local { get; protected set; }
		IPluginContext pluginContext;

		internal SPBuffer(IPluginContext pluginContext, int local)
		{
			this.pluginContext = pluginContext;
			Local = local;
		}

		public uint Set(string str, uint maxLength)
		{
			uint wrtnbytes;
			pluginContext.StringToLocalUTF8(Local, maxLength, str, out wrtnbytes);
			return wrtnbytes;
		}

		public string Get()
		{
			string str;
			if (pluginContext.LocalToString(Local, out str) == 0) {
				return str;
			} else {
				return null;
			}

		}
	}
	public partial class IPluginFunction : ICallable {

		private int[] ObjectParams(object[] @params)
		{
			int[] ret = new int[@params.Length];
			for (int i = 0; i < @params.Length; i++) {
				var param = @params[i];
				if (param == null) {
					ret[i] = 0;
				} else {
					if (param == null) {
						ret[i] = 0;
					} else {
						var type = param.GetType();
						ret[i] = AlliedMods.SourceMod.IShareSys.GetSP(type, param);
					}
				}
			}
			return ret;
		}

		public int CallFunction (params object[] @params)
		{
			int result;
			return CallFunction (out result, @params);
		}
		public int CallFunction (out int result, params object[] @params)
		{
			return CallFunction (ObjectParams(@params), out result);
		}
		public int CallFunction (int[] @params)
		{
			int result;
			return CallFunction (@params, out result);
		}
		public int CallFunction (int[] @params, out int result)
		{
			var handle = GCHandle.Alloc(@params, GCHandleType.Pinned);
			var ret = CallFunction(handle.AddrOfPinnedObject(), (uint)@params.Length, out result);
			handle.Free();
			return ret;
		}

		public int CallFunction2 (SourcePawn.IPluginContext ctx, params object[] @params)
		{
			int result;
			return CallFunction2 (ctx, out result, @params);
		}
		public int CallFunction2 (SourcePawn.IPluginContext ctx, out int result, params object[] @params)
		{
			return CallFunction2 (ctx, ObjectParams(@params), out result);
		}
		public int CallFunction2 (SourcePawn.IPluginContext ctx, int[] @params)
		{
			int result;
			return CallFunction2 (ctx, @params, out result);
		}
		public int CallFunction2 (SourcePawn.IPluginContext ctx, int[] @params, out int result)
		{
			var handle = GCHandle.Alloc(@params, GCHandleType.Pinned);
			var ret = CallFunction2(ctx, handle.AddrOfPinnedObject(), (uint)@params.Length, out result);
			handle.Free();
			return ret;
		}
	}
}

