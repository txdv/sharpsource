using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace SharpSource
{
	public interface INativeWrapper
    {
        void SetupFunctions(IntPtr objectAddress);
    }

    public abstract class NativeWrapper<TNativeFunctions> : INativeWrapper
    {
        protected IntPtr ObjectAddress;

        public IntPtr Interface
        {
            get { return ObjectAddress; }
        }

        public TNativeFunctions Functions;

        public override string ToString()
        {
            return string.Format(
                "Interface<{0}> #{1:X8}",
                typeof(TNativeFunctions),
                this.ObjectAddress.ToInt32());
        }


        public void SetupFunctions(IntPtr objectAddress)
        {
            this.ObjectAddress = objectAddress;

            IntPtr vtableptr = Marshal.ReadIntPtr(this.ObjectAddress);

            this.Functions = (TNativeFunctions)Marshal.PtrToStructure(
                vtableptr, typeof(TNativeFunctions));
        }

        private Dictionary<IntPtr, Delegate> FunctionCache = new Dictionary<IntPtr, Delegate>();

        protected Delegate GetDelegate<TDelegate>(IntPtr pointer)
        {
            Delegate function;

            if (this.FunctionCache.ContainsKey(pointer) == false)
            {
                function = Marshal.GetDelegateForFunctionPointer(pointer, typeof(TDelegate));
                this.FunctionCache[pointer] = function;
            }
            else
            {
                function = this.FunctionCache[pointer];
            }

            return function;
        }

        protected TDelegate GetFunction<TDelegate>(IntPtr pointer)
            where TDelegate : class
        {
            return (TDelegate)((object)this.GetDelegate<TDelegate>(pointer));
        }

        protected void Call<TDelegate>(IntPtr pointer, params object[] args)
        {
            this.GetDelegate<TDelegate>(pointer).DynamicInvoke(args);
        }

        protected TReturn Call<TReturn, TDelegate>(IntPtr pointer, params object[] args)
        {
            return (TReturn)this.GetDelegate<TDelegate>(pointer).DynamicInvoke(args);
        }
    }

	public class SteamWorks
	{
        public static TClass CastInterface<TClass>(IntPtr address)
            where TClass : INativeWrapper, new()
        {
            if (address == IntPtr.Zero)
            {
                return default(TClass);
            }

            var rez = new TClass();
            rez.SetupFunctions(address);
            return rez;
        }
    }

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 4)]
	public class ISourceModTable
	{
		public IntPtr GetInterfaceName;
		public IntPtr GetInterfaceVersion;
		public IntPtr GetGamePath;
		public IntPtr GetSourceModPath;
		public IntPtr BuildPath;
		public IntPtr LogMessage;
		public IntPtr LogError;
		public IntPtr FormatString;
		public IntPtr CreateDataPack;
		public IntPtr FreeDataPack;
		public IntPtr GetDataPackHandleType;
		public IntPtr ReadKeyValuesHandle;
		public IntPtr GetGameFolderName;
		public IntPtr GetScriptingEngine;
		public IntPtr GetScriptingVM;
		public IntPtr GetAdjustedTime;
		public IntPtr SetGlobalTarget;
		public IntPtr GetGlobalTarget;
		public IntPtr AddGameFrameHook;
		public IntPtr RemoveGameFrameHook;
		public IntPtr Format;
		public IntPtr FormatArgs;
		public IntPtr AddFrameAction;
		public IntPtr GetCoreConfigValue;
		public IntPtr GetPluginId;
	}

	
	public class ISourceMod : NativeWrapper<ISourceModTable>
	{
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate IntPtr NativeGetInterfaceName(IntPtr thisobj);
		[return: MarshalAs(UnmanagedType.I1)] public IntPtr GetInterfaceName() { var call = this.GetFunction<NativeGetInterfaceName>(this.Functions.GetInterfaceName); return call(this.ObjectAddress); }
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate IntPtr NativeGetInterfaceVersion(IntPtr thisobj);
		[return: MarshalAs(UnmanagedType.I1)] public IntPtr GetInterfaceVersion() { var call = this.GetFunction<NativeGetInterfaceVersion>(this.Functions.GetInterfaceVersion); return call(this.ObjectAddress); }
	}
	
	public class MainClass
	{
		
		public static void Init(IntPtr ptr)
		{
			Console.WriteLine("C#: Hello World!");
			
			ISourceMod sm = SteamWorks.CastInterface<ISourceMod>(ptr);

			Console.WriteLine (sm);
			Console.WriteLine (sm.Functions.GetInterfaceName);
			Console.WriteLine (sm.Functions.GetInterfaceVersion);
			Console.WriteLine (sm.GetInterfaceName()); // returns 11
			Console.WriteLine (sm.GetInterfaceVersion()); // returns nasty pointer
		}
	}
}