// -------------------------------------------------------------------------
//  Managed wrapper for IShareSys
//  Generated from bindings.xml on 02/28/2012 15:56:54
//
//  This file was auto generated. Do not edit.
// -------------------------------------------------------------------------

using System;
using Mono.Cxxi;

namespace AlliedMods.SourceMod {
	public partial class IShareSys : ICppObject {

		private static readonly IIShareSys impl = Libs.AlliedMods.GetClass<IIShareSys,_IShareSys,IShareSys> ("IShareSys");
		public CppInstancePtr Native { get; protected set; }

		[MangleAs ("class SourceMod::IShareSys")]
		public partial interface IIShareSys : ICppClassOverridable<IShareSys> {
			[Virtual] bool AddInterface (CppInstancePtr @this, SourceMod.IExtension myself, SourceMod.SMInterface iface);
			[Virtual] bool RequestInterface (CppInstancePtr @this, string iface_name, uint iface_vers, SourceMod.IExtension myself, IntPtr pIface);
			[Virtual] void AddNatives (CppInstancePtr @this, SourceMod.IExtension myself, sp_nativeinfo_s[] natives);
			[Virtual] uint CreateIdentType (CppInstancePtr @this, string name);
			[Virtual] uint FindIdentType (CppInstancePtr @this, string name);
			[Virtual] void CreateIdentity (CppInstancePtr @this, uint type, IntPtr ptr);
			[Virtual] void DestroyIdentType (CppInstancePtr @this, uint type);
			[Virtual] void DestroyIdentity (CppInstancePtr @this, IntPtr identity);
			[Virtual] void AddDependency (CppInstancePtr @this, SourceMod.IExtension myself, string filename, bool require, bool autoload);
			[Virtual] void RegisterLibrary (CppInstancePtr @this, SourceMod.IExtension myself, string name);
			[Virtual] void OverrideNatives (CppInstancePtr @this, SourceMod.IExtension myself, sp_nativeinfo_s natives);
			[Virtual] void AddCapabilityProvider (CppInstancePtr @this, SourceMod.IExtension myself, SourceMod.IFeatureProvider provider, string name);
			[Virtual] void DropCapabilityProvider (CppInstancePtr @this, SourceMod.IExtension myself, SourceMod.IFeatureProvider provider, string name);
		}
		public unsafe struct _IShareSys {
		}




		public IShareSys (CppTypeInfo subClass)
		{
			__cxxi_LayoutClass ();
			subClass.AddBase (impl.TypeInfo);
		}

		public IShareSys (CppInstancePtr native)
		{
			__cxxi_LayoutClass ();
			Native = native;
		}

		[OverrideNative ("AddInterface")]
		public virtual bool AddInterface (SourceMod.IExtension myself, SourceMod.SMInterface iface)
		{
			return impl.AddInterface (Native, myself, iface);
		}
		[OverrideNative ("RequestInterface")]
		public virtual bool RequestInterface (string iface_name, uint iface_vers, SourceMod.IExtension myself, IntPtr pIface)
		{
			return impl.RequestInterface (Native, iface_name, iface_vers, myself, pIface);
		}
		[OverrideNative ("AddNatives")]
		public virtual void AddNatives (SourceMod.IExtension myself, sp_nativeinfo_s[] natives)
		{
			impl.AddNatives (Native, myself, natives);
		}
		[OverrideNative ("CreateIdentType")]
		public virtual uint CreateIdentType (string name)
		{
			return impl.CreateIdentType (Native, name);
		}
		[OverrideNative ("FindIdentType")]
		public virtual uint FindIdentType (string name)
		{
			return impl.FindIdentType (Native, name);
		}
		[OverrideNative ("DestroyIdentType")]
		public virtual void DestroyIdentType (uint type)
		{
			impl.DestroyIdentType (Native, type);
		}
		[OverrideNative ("AddDependency")]
		public virtual void AddDependency (SourceMod.IExtension myself, string filename, bool require, bool autoload)
		{
			impl.AddDependency (Native, myself, filename, require, autoload);
		}
		[OverrideNative ("RegisterLibrary")]
		public virtual void RegisterLibrary (SourceMod.IExtension myself, string name)
		{
			impl.RegisterLibrary (Native, myself, name);
		}
		[OverrideNative ("OverrideNatives")]
		public virtual void OverrideNatives (SourceMod.IExtension myself, sp_nativeinfo_s natives)
		{
			impl.OverrideNatives (Native, myself, natives);
		}
		[OverrideNative ("AddCapabilityProvider")]
		public virtual void AddCapabilityProvider (SourceMod.IExtension myself, SourceMod.IFeatureProvider provider, string name)
		{
			impl.AddCapabilityProvider (Native, myself, provider, name);
		}
		[OverrideNative ("DropCapabilityProvider")]
		public virtual void DropCapabilityProvider (SourceMod.IExtension myself, SourceMod.IFeatureProvider provider, string name)
		{
			impl.DropCapabilityProvider (Native, myself, provider, name);
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

