// -------------------------------------------------------------------------
//  Managed wrapper for IFeatureProvider
//  Generated from bindings.xml on 02/28/2012 15:56:54
//
//  This file was auto generated. Do not edit.
// -------------------------------------------------------------------------

using System;
using Mono.Cxxi;

namespace AlliedMods.SourceMod {
	public partial class IFeatureProvider : ICppObject {

		private static readonly IIFeatureProvider impl = Libs.AlliedMods.GetClass<IIFeatureProvider,_IFeatureProvider,IFeatureProvider> ("IFeatureProvider");
		public CppInstancePtr Native { get; protected set; }

		[MangleAs ("class SourceMod::IFeatureProvider")]
		public partial interface IIFeatureProvider : ICppClassOverridable<IFeatureProvider> {
			[Virtual] SourceMod.FeatureStatus GetFeatureStatus (CppInstancePtr @this, SourceMod.FeatureType type, string name);
		}
		public unsafe struct _IFeatureProvider {
		}




		public IFeatureProvider (CppTypeInfo subClass)
		{
			__cxxi_LayoutClass ();
			subClass.AddBase (impl.TypeInfo);
		}

		public IFeatureProvider (CppInstancePtr native)
		{
			__cxxi_LayoutClass ();
			Native = native;
		}

		[OverrideNative ("GetFeatureStatus")]
		public virtual SourceMod.FeatureStatus GetFeatureStatus (SourceMod.FeatureType type, string name)
		{
			return impl.GetFeatureStatus (Native, type, name);
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

