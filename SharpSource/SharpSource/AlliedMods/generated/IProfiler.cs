// -------------------------------------------------------------------------
//  Managed wrapper for IProfiler
//  Generated from bindings.xml on 02/28/2012 15:56:54
//
//  This file was auto generated. Do not edit.
// -------------------------------------------------------------------------

using System;
using Mono.Cxxi;

namespace AlliedMods.SourcePawn {
	public partial class IProfiler : ICppObject {

		private static readonly IIProfiler impl = Libs.AlliedMods.GetClass<IIProfiler,_IProfiler,IProfiler> ("IProfiler");
		public CppInstancePtr Native { get; protected set; }

		[MangleAs ("class SourcePawn::IProfiler")]
		public partial interface IIProfiler : ICppClassOverridable<IProfiler> {
			[Virtual] void OnNativeBegin (CppInstancePtr @this, SourcePawn.IPluginContext pContext, sp_native_s native);
			[Virtual] void OnNativeEnd (CppInstancePtr @this);
			[Virtual] void OnFunctionBegin (CppInstancePtr @this, SourcePawn.IPluginContext pContext, string name);
			[Virtual] void OnFunctionEnd (CppInstancePtr @this);
			[Virtual] int OnCallbackBegin (CppInstancePtr @this, SourcePawn.IPluginContext pContext, sp_public_s pubfunc);
			[Virtual] void OnCallbackEnd (CppInstancePtr @this, int serial);
		}
		public unsafe struct _IProfiler {
		}




		public IProfiler (CppTypeInfo subClass)
		{
			__cxxi_LayoutClass ();
			subClass.AddBase (impl.TypeInfo);
		}

		public IProfiler (CppInstancePtr native)
		{
			__cxxi_LayoutClass ();
			Native = native;
		}

		[OverrideNative ("OnNativeBegin")]
		public virtual void OnNativeBegin (SourcePawn.IPluginContext pContext, sp_native_s native)
		{
			impl.OnNativeBegin (Native, pContext, native);
		}
		[OverrideNative ("OnNativeEnd")]
		public virtual void OnNativeEnd ()
		{
			impl.OnNativeEnd (Native);
		}
		[OverrideNative ("OnFunctionBegin")]
		public virtual void OnFunctionBegin (SourcePawn.IPluginContext pContext, string name)
		{
			impl.OnFunctionBegin (Native, pContext, name);
		}
		[OverrideNative ("OnFunctionEnd")]
		public virtual void OnFunctionEnd ()
		{
			impl.OnFunctionEnd (Native);
		}
		[OverrideNative ("OnCallbackBegin")]
		public virtual int OnCallbackBegin (SourcePawn.IPluginContext pContext, sp_public_s pubfunc)
		{
			return impl.OnCallbackBegin (Native, pContext, pubfunc);
		}
		[OverrideNative ("OnCallbackEnd")]
		public virtual void OnCallbackEnd (int serial)
		{
			impl.OnCallbackEnd (Native, serial);
		}


		partial void BeforeDestruct ();
		partial void AfterDestruct ();

		public virtual void Dispose ()
		{
			BeforeDestruct ();
			Native.Dispose ();
			AfterDestruct ();
		}

		private void __cxxi_LayoutClass ()
		{
			impl.TypeInfo.CompleteType ();
		}

	}
}

