// -------------------------------------------------------------------------
//  Managed wrapper for IPluginRuntime
//  Generated from bindings.xml on 02/28/2012 15:56:54
//
//  This file was auto generated. Do not edit.
// -------------------------------------------------------------------------

using System;
using Mono.Cxxi;

namespace AlliedMods.SourcePawn {
	public partial class IPluginRuntime : ICppObject {

		private static readonly IIPluginRuntime impl = Libs.AlliedMods.GetClass<IIPluginRuntime,_IPluginRuntime,IPluginRuntime> ("IPluginRuntime");
		public CppInstancePtr Native { get; protected set; }

		[MangleAs ("class SourcePawn::IPluginRuntime")]
		public partial interface IIPluginRuntime : ICppClassOverridable<IPluginRuntime> {
			[Virtual] [Inline] [Destructor] void Destruct (CppInstancePtr @this);
			[Virtual] SourcePawn.IPluginDebugInfo GetDebugInfo (CppInstancePtr @this);
			[Virtual] int FindNativeByName (CppInstancePtr @this, string name, ref uint index);
			[Virtual] int GetNativeByIndex (CppInstancePtr @this, uint index, IntPtr native);
			[Virtual] uint GetNativesNum (CppInstancePtr @this);
			[Virtual] int FindPublicByName (CppInstancePtr @this, string name, ref uint index);
			[Virtual] int GetPublicByIndex (CppInstancePtr @this, uint index, IntPtr publicptr);
			[Virtual] uint GetPublicsNum (CppInstancePtr @this);
			[Virtual] int GetPubvarByIndex (CppInstancePtr @this, uint index, IntPtr pubvar);
			[Virtual] int FindPubvarByName (CppInstancePtr @this, string name, ref uint index);
			[Virtual] int GetPubvarAddrs (CppInstancePtr @this, uint index, ref int local_addr, IntPtr phys_addr);
			[Virtual] uint GetPubVarsNum (CppInstancePtr @this);
			[Virtual] SourcePawn.IPluginFunction GetFunctionByName (CppInstancePtr @this, string public_name);
			[Virtual] SourcePawn.IPluginFunction GetFunctionById (CppInstancePtr @this, uint func_id);
			[Virtual] SourcePawn.IPluginContext GetDefaultContext (CppInstancePtr @this);
			[Virtual] bool IsDebugging (CppInstancePtr @this);
			[Virtual] int ApplyCompilationOptions (CppInstancePtr @this, SourcePawn.ICompilation co);
			[Virtual] void SetPauseState (CppInstancePtr @this, bool paused);
			[Virtual] bool IsPaused (CppInstancePtr @this);
			[Virtual] uint GetMemUsage (CppInstancePtr @this);
		}
		public unsafe struct _IPluginRuntime {
		}




		public IPluginRuntime (CppTypeInfo subClass)
		{
			__cxxi_LayoutClass ();
			subClass.AddBase (impl.TypeInfo);
		}

		public IPluginRuntime (CppInstancePtr native)
		{
			__cxxi_LayoutClass ();
			Native = native;
		}

		[OverrideNative ("GetDebugInfo")]
		public virtual SourcePawn.IPluginDebugInfo GetDebugInfo ()
		{
			return impl.GetDebugInfo (Native);
		}
		[OverrideNative ("FindNativeByName")]
		public virtual int FindNativeByName (string name, ref uint index)
		{
			return impl.FindNativeByName (Native, name, ref index);
		}
		[OverrideNative ("GetNativeByIndex")]
		public virtual int GetNativeByIndex (uint index, IntPtr native)
		{
			return impl.GetNativeByIndex (Native, index, native);
		}
		[OverrideNative ("GetNativesNum")]
		public virtual uint GetNativesNum ()
		{
			return impl.GetNativesNum (Native);
		}
		[OverrideNative ("FindPublicByName")]
		public virtual int FindPublicByName (string name, ref uint index)
		{
			return impl.FindPublicByName (Native, name, ref index);
		}
		[OverrideNative ("GetPublicByIndex")]
		public virtual int GetPublicByIndex (uint index, IntPtr publicptr)
		{
			return impl.GetPublicByIndex (Native, index, publicptr);
		}
		[OverrideNative ("GetPublicsNum")]
		public virtual uint GetPublicsNum ()
		{
			return impl.GetPublicsNum (Native);
		}
		[OverrideNative ("GetPubvarByIndex")]
		public virtual int GetPubvarByIndex (uint index, IntPtr pubvar)
		{
			return impl.GetPubvarByIndex (Native, index, pubvar);
		}
		[OverrideNative ("FindPubvarByName")]
		public virtual int FindPubvarByName (string name, ref uint index)
		{
			return impl.FindPubvarByName (Native, name, ref index);
		}
		[OverrideNative ("GetPubvarAddrs")]
		public virtual int GetPubvarAddrs (uint index, ref int local_addr, IntPtr phys_addr)
		{
			return impl.GetPubvarAddrs (Native, index, ref local_addr, phys_addr);
		}
		[OverrideNative ("GetPubVarsNum")]
		public virtual uint GetPubVarsNum ()
		{
			return impl.GetPubVarsNum (Native);
		}
		[OverrideNative ("GetFunctionByName")]
		public virtual SourcePawn.IPluginFunction GetFunctionByName (string public_name)
		{
			return impl.GetFunctionByName (Native, public_name);
		}
		[OverrideNative ("GetFunctionById")]
		public virtual SourcePawn.IPluginFunction GetFunctionById (uint func_id)
		{
			return impl.GetFunctionById (Native, func_id);
		}
		[OverrideNative ("GetDefaultContext")]
		public virtual SourcePawn.IPluginContext GetDefaultContext ()
		{
			return impl.GetDefaultContext (Native);
		}
		[OverrideNative ("IsDebugging")]
		public virtual bool IsDebugging ()
		{
			return impl.IsDebugging (Native);
		}
		[OverrideNative ("ApplyCompilationOptions")]
		public virtual int ApplyCompilationOptions (SourcePawn.ICompilation co)
		{
			return impl.ApplyCompilationOptions (Native, co);
		}
		[OverrideNative ("SetPauseState")]
		public virtual void SetPauseState (bool paused)
		{
			impl.SetPauseState (Native, paused);
		}
		[OverrideNative ("IsPaused")]
		public virtual bool IsPaused ()
		{
			return impl.IsPaused (Native);
		}
		[OverrideNative ("GetMemUsage")]
		public virtual uint GetMemUsage ()
		{
			return impl.GetMemUsage (Native);
		}


		partial void BeforeDestruct ();
		partial void AfterDestruct ();

		public virtual void Dispose ()
		{
			BeforeDestruct ();
			impl.Destruct (Native);
			Native.Dispose ();
			AfterDestruct ();
		}

		private void __cxxi_LayoutClass ()
		{
			impl.TypeInfo.CompleteType ();
		}

	}
}

