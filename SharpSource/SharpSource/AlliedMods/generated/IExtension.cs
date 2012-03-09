// -------------------------------------------------------------------------
//  Managed wrapper for IExtension
//  Generated from bindings.xml on 02/28/2012 15:56:54
//
//  This file was auto generated. Do not edit.
// -------------------------------------------------------------------------

using System;
using Mono.Cxxi;

namespace AlliedMods.SourceMod {
	public partial class IExtension : ICppObject {

		private static readonly IIExtension impl = Libs.AlliedMods.GetClass<IIExtension,_IExtension,IExtension> ("IExtension");
		public CppInstancePtr Native { get; protected set; }

		[MangleAs ("class SourceMod::IExtension")]
		public partial interface IIExtension : ICppClassOverridable<IExtension> {
			[Virtual] bool IsLoaded (CppInstancePtr @this);
			[Virtual] SourceMod.IExtensionInterface GetAPI (CppInstancePtr @this);
			[Virtual] IntPtr GetFilename (CppInstancePtr @this);
			[Virtual] void GetIdentity (CppInstancePtr @this);
			[Virtual] IntPtr FindFirstDependency (CppInstancePtr @this, ref IntPtr pOwner, ref IntPtr pInterface);
			[Virtual] bool FindNextDependency (CppInstancePtr @this, IntPtr iter, IntPtr pOwner, IntPtr pInterface);
			[Virtual] void FreeDependencyIterator (CppInstancePtr @this, IntPtr iter);
			[Virtual] bool IsRunning (CppInstancePtr @this, string error, uint maxlength);
			[Virtual] bool IsExternal (CppInstancePtr @this);
		}
		public unsafe struct _IExtension {
		}




		public IExtension (CppTypeInfo subClass)
		{
			__cxxi_LayoutClass ();
			subClass.AddBase (impl.TypeInfo);
		}

		public IExtension (CppInstancePtr native)
		{
			__cxxi_LayoutClass ();
			Native = native;
		}

		[OverrideNative ("IsLoaded")]
		public virtual bool IsLoaded ()
		{
			return impl.IsLoaded (Native);
		}
		[OverrideNative ("GetAPI")]
		public virtual SourceMod.IExtensionInterface GetAPI ()
		{
			return impl.GetAPI (Native);
		}
		[OverrideNative ("GetFilename")]
		public virtual IntPtr GetFilename ()
		{
			return impl.GetFilename (Native);
		}
		[OverrideNative ("FindFirstDependency")]
		public virtual IntPtr FindFirstDependency (ref IntPtr pOwner, ref IntPtr pInterface)
		{
			return impl.FindFirstDependency (Native, ref pOwner, ref pInterface);
		}
		[OverrideNative ("FindNextDependency")]
		public virtual bool FindNextDependency (IntPtr iter, IntPtr pOwner, IntPtr pInterface)
		{
			return impl.FindNextDependency (Native, iter, pOwner, pInterface);
		}
		[OverrideNative ("FreeDependencyIterator")]
		public virtual void FreeDependencyIterator (IntPtr iter)
		{
			impl.FreeDependencyIterator (Native, iter);
		}
		[OverrideNative ("IsRunning")]
		public virtual bool IsRunning (string error, uint maxlength)
		{
			return impl.IsRunning (Native, error, maxlength);
		}
		[OverrideNative ("IsExternal")]
		public virtual bool IsExternal ()
		{
			return impl.IsExternal (Native);
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

