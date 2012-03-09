// -------------------------------------------------------------------------
//  Managed wrapper for IHandleTypeDispatch
//  Generated from bindings.xml on 02/28/2012 15:56:54
//
//  This file was auto generated. Do not edit.
// -------------------------------------------------------------------------

using System;
using Mono.Cxxi;

namespace AlliedMods.SourceMod {
	public partial class IHandleTypeDispatch : ICppObject {

		private static readonly IIHandleTypeDispatch impl = Libs.AlliedMods.GetClass<IIHandleTypeDispatch,_IHandleTypeDispatch,IHandleTypeDispatch> ("IHandleTypeDispatch");
		public CppInstancePtr Native { get; protected set; }

		[MangleAs ("class SourceMod::IHandleTypeDispatch")]
		public partial interface IIHandleTypeDispatch : ICppClassOverridable<IHandleTypeDispatch> {
			[Virtual] [Inline] uint GetDispatchVersion (CppInstancePtr @this);
			[Virtual] void OnHandleDestroy (CppInstancePtr @this, uint type, IntPtr @object);
			[Virtual] [Inline] bool GetHandleApproxSize (CppInstancePtr @this, uint type, IntPtr @object, ref uint pSize);
		}
		public unsafe struct _IHandleTypeDispatch {
		}




		public IHandleTypeDispatch (CppTypeInfo subClass)
		{
			__cxxi_LayoutClass ();
			subClass.AddBase (impl.TypeInfo);
		}

		public IHandleTypeDispatch (CppInstancePtr native)
		{
			__cxxi_LayoutClass ();
			Native = native;
		}

		[OverrideNative ("OnHandleDestroy")]
		public virtual void OnHandleDestroy (uint type, IntPtr @object)
		{
			impl.OnHandleDestroy (Native, type, @object);
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

