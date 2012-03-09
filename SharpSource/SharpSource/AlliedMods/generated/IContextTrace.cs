// -------------------------------------------------------------------------
//  Managed wrapper for IContextTrace
//  Generated from bindings.xml on 02/28/2012 15:56:54
//
//  This file was auto generated. Do not edit.
// -------------------------------------------------------------------------

using System;
using Mono.Cxxi;

namespace AlliedMods.SourcePawn {
	public partial class IContextTrace : ICppObject {

		private static readonly IIContextTrace impl = Libs.AlliedMods.GetClass<IIContextTrace,_IContextTrace,IContextTrace> ("IContextTrace");
		public CppInstancePtr Native { get; protected set; }

		[MangleAs ("class SourcePawn::IContextTrace")]
		public partial interface IIContextTrace : ICppClassOverridable<IContextTrace> {
			[Virtual] int GetErrorCode (CppInstancePtr @this);
			[Virtual] string GetErrorString (CppInstancePtr @this);
			[Virtual] bool DebugInfoAvailable (CppInstancePtr @this);
			[Virtual] string GetCustomErrorString (CppInstancePtr @this);
			[Virtual] bool GetTraceInfo (CppInstancePtr @this, SourcePawn.CallStackInfo trace);
			[Virtual] void ResetTrace (CppInstancePtr @this);
			[Virtual] string GetLastNative (CppInstancePtr @this, ref uint index);
		}
		public unsafe struct _IContextTrace {
		}




		public IContextTrace (CppTypeInfo subClass)
		{
			__cxxi_LayoutClass ();
			subClass.AddBase (impl.TypeInfo);
		}

		public IContextTrace (CppInstancePtr native)
		{
			__cxxi_LayoutClass ();
			Native = native;
		}

		[OverrideNative ("GetErrorCode")]
		public virtual int GetErrorCode ()
		{
			return impl.GetErrorCode (Native);
		}
		[OverrideNative ("GetErrorString")]
		public virtual string GetErrorString ()
		{
			return impl.GetErrorString (Native);
		}
		[OverrideNative ("DebugInfoAvailable")]
		public virtual bool DebugInfoAvailable ()
		{
			return impl.DebugInfoAvailable (Native);
		}
		[OverrideNative ("GetCustomErrorString")]
		public virtual string GetCustomErrorString ()
		{
			return impl.GetCustomErrorString (Native);
		}
		[OverrideNative ("GetTraceInfo")]
		public virtual bool GetTraceInfo (SourcePawn.CallStackInfo trace)
		{
			return impl.GetTraceInfo (Native, trace);
		}
		[OverrideNative ("ResetTrace")]
		public virtual void ResetTrace ()
		{
			impl.ResetTrace (Native);
		}
		[OverrideNative ("GetLastNative")]
		public virtual string GetLastNative (ref uint index)
		{
			return impl.GetLastNative (Native, ref index);
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

