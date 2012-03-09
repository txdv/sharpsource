// -------------------------------------------------------------------------
//  Managed wrapper for IHandleSys
//  Generated from bindings.xml on 02/28/2012 15:56:54
//
//  This file was auto generated. Do not edit.
// -------------------------------------------------------------------------

using System;
using Mono.Cxxi;

namespace AlliedMods.SourceMod {
	public partial class IHandleSys : SMInterface {

		private static readonly IIHandleSys impl = Libs.AlliedMods.GetClass<IIHandleSys,_IHandleSys,IHandleSys> ("IHandleSys");

		[MangleAs ("class SourceMod::IHandleSys")]
		public partial interface IIHandleSys : ICppClassOverridable<IHandleSys> {
			[Virtual] uint CreateType (CppInstancePtr @this, string name, SourceMod.IHandleTypeDispatch dispatch, uint parent, SourceMod.TypeAccess typeAccess, SourceMod.HandleAccess hndlAccess, IntPtr ident, IntPtr err);
			[Virtual] bool RemoveType (CppInstancePtr @this, uint type, IntPtr ident);
			[Virtual] bool FindHandleType (CppInstancePtr @this, string name, ref uint type);
			[Virtual] uint CreateHandle (CppInstancePtr @this, uint type, IntPtr @object, IntPtr owner, IntPtr ident, IntPtr err);
			[Virtual] SourceMod.HandleError FreeHandle (CppInstancePtr @this, uint handle, SourceMod.HandleSecurity pSecurity);
			[Virtual] SourceMod.HandleError CloneHandle (CppInstancePtr @this, uint handle, ref uint newhandle, IntPtr newOwner, SourceMod.HandleSecurity pSecurity);
			[Virtual] SourceMod.HandleError ReadHandle (CppInstancePtr @this, uint handle, uint type, SourceMod.HandleSecurity pSecurity, IntPtr @object);
			[Virtual] bool InitAccessDefaults (CppInstancePtr @this, SourceMod.TypeAccess pTypeAccess, SourceMod.HandleAccess pHandleAccess);
			[Virtual] uint CreateHandleEx (CppInstancePtr @this, uint type, IntPtr @object, SourceMod.HandleSecurity pSec, SourceMod.HandleAccess pAccess, IntPtr err);
			[Virtual] uint FastCloneHandle (CppInstancePtr @this, uint hndl);
		}
		public unsafe struct _IHandleSys {
		}




		public IHandleSys (CppTypeInfo subClass)
			: base (impl.TypeInfo)
		{
			__cxxi_LayoutClass ();
			subClass.AddBase (impl.TypeInfo);
		}

		public IHandleSys (CppInstancePtr native)
			: base (impl.TypeInfo)
		{
			__cxxi_LayoutClass ();
			Native = native;
		}

		[OverrideNative ("FindHandleType")]
		public virtual bool FindHandleType (string name, ref uint type)
		{
			return impl.FindHandleType (Native, name, ref type);
		}
		[OverrideNative ("FreeHandle")]
		public virtual SourceMod.HandleError FreeHandle (uint handle, SourceMod.HandleSecurity pSecurity)
		{
			return impl.FreeHandle (Native, handle, pSecurity);
		}
		[OverrideNative ("ReadHandle")]
		public virtual SourceMod.HandleError ReadHandle (uint handle, uint type, SourceMod.HandleSecurity pSecurity, IntPtr @object)
		{
			return impl.ReadHandle (Native, handle, type, pSecurity, @object);
		}
		[OverrideNative ("InitAccessDefaults")]
		public virtual bool InitAccessDefaults (SourceMod.TypeAccess pTypeAccess, SourceMod.HandleAccess pHandleAccess)
		{
			return impl.InitAccessDefaults (Native, pTypeAccess, pHandleAccess);
		}
		[OverrideNative ("CreateHandleEx")]
		public virtual uint CreateHandleEx (uint type, IntPtr @object, SourceMod.HandleSecurity pSec, SourceMod.HandleAccess pAccess, IntPtr err)
		{
			return impl.CreateHandleEx (Native, type, @object, pSec, pAccess, err);
		}
		[OverrideNative ("FastCloneHandle")]
		public virtual uint FastCloneHandle (uint hndl)
		{
			return impl.FastCloneHandle (Native, hndl);
		}


		partial void BeforeDestruct ();
		partial void AfterDestruct ();

		public override void Dispose ()
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

