// -------------------------------------------------------------------------
//  Managed wrapper for IExtensionManager
//  Generated from bindings.xml on 02/28/2012 15:56:54
//
//  This file was auto generated. Do not edit.
// -------------------------------------------------------------------------

using System;
using Mono.Cxxi;

namespace AlliedMods.SourceMod {
	public partial class IExtensionManager : SMInterface {

		private static readonly IIExtensionManager impl = Libs.AlliedMods.GetClass<IIExtensionManager,_IExtensionManager,IExtensionManager> ("IExtensionManager");

		[MangleAs ("class SourceMod::IExtensionManager")]
		public partial interface IIExtensionManager : ICppClassOverridable<IExtensionManager> {
			[Virtual] SourceMod.IExtension LoadExtension (CppInstancePtr @this, string path, string error, uint maxlength);
			[Virtual] SourceMod.IExtension LoadExternal (CppInstancePtr @this, SourceMod.IExtensionInterface pInterface, string filepath, string filename, string error, uint maxlength);
			[Virtual] bool UnloadExtension (CppInstancePtr @this, SourceMod.IExtension pExt);
		}
		public unsafe struct _IExtensionManager {
		}




		public IExtensionManager (CppTypeInfo subClass)
			: base (impl.TypeInfo)
		{
			__cxxi_LayoutClass ();
			subClass.AddBase (impl.TypeInfo);
		}

		public IExtensionManager (CppInstancePtr native)
			: base (impl.TypeInfo)
		{
			__cxxi_LayoutClass ();
			Native = native;
		}

		[OverrideNative ("LoadExtension")]
		public virtual SourceMod.IExtension LoadExtension (string path, string error, uint maxlength)
		{
			return impl.LoadExtension (Native, path, error, maxlength);
		}
		[OverrideNative ("LoadExternal")]
		public virtual SourceMod.IExtension LoadExternal (SourceMod.IExtensionInterface pInterface, string filepath, string filename, string error, uint maxlength)
		{
			return impl.LoadExternal (Native, pInterface, filepath, filename, error, maxlength);
		}
		[OverrideNative ("UnloadExtension")]
		public virtual bool UnloadExtension (SourceMod.IExtension pExt)
		{
			return impl.UnloadExtension (Native, pExt);
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

