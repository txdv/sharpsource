// -------------------------------------------------------------------------
//  Managed wrapper for IDebugListener
//  Generated from bindings.xml on 02/28/2012 15:56:54
//
//  This file was auto generated. Do not edit.
// -------------------------------------------------------------------------

using System;
using Mono.Cxxi;

namespace AlliedMods.SourcePawn {
	public partial class IDebugListener : ICppObject {

		private static readonly IIDebugListener impl = Libs.AlliedMods.GetClass<IIDebugListener,_IDebugListener,IDebugListener> ("IDebugListener");
		public CppInstancePtr Native { get; protected set; }

		[MangleAs ("class SourcePawn::IDebugListener")]
		public partial interface IIDebugListener : ICppClassOverridable<IDebugListener> {
			[Virtual] void OnContextExecuteError (CppInstancePtr @this, SourcePawn.IPluginContext ctx, SourcePawn.IContextTrace error);
			[Virtual] void OnDebugSpew (CppInstancePtr @this, string msg);
		}
		public unsafe struct _IDebugListener {
		}




		public IDebugListener (CppTypeInfo subClass)
		{
			__cxxi_LayoutClass ();
			subClass.AddBase (impl.TypeInfo);
		}

		public IDebugListener (CppInstancePtr native)
		{
			__cxxi_LayoutClass ();
			Native = native;
		}

		[OverrideNative ("OnContextExecuteError")]
		public virtual void OnContextExecuteError (SourcePawn.IPluginContext ctx, SourcePawn.IContextTrace error)
		{
			impl.OnContextExecuteError (Native, ctx, error);
		}
		[OverrideNative ("OnDebugSpew")]
		public virtual void OnDebugSpew (string msg)
		{
			impl.OnDebugSpew (Native, msg);
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

