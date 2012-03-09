// -------------------------------------------------------------------------
//  Managed wrapper for IExtensionInterface
//  Generated from bindings.xml on 02/28/2012 15:56:54
//
//  This file was auto generated. Do not edit.
// -------------------------------------------------------------------------

using System;
using Mono.Cxxi;

namespace AlliedMods.SourceMod {
	public partial class IExtensionInterface : ICppObject {

		private static readonly IIExtensionInterface impl = Libs.AlliedMods.GetClass<IIExtensionInterface,_IExtensionInterface,IExtensionInterface> ("IExtensionInterface");
		public CppInstancePtr Native { get; protected set; }

		[MangleAs ("class SourceMod::IExtensionInterface")]
		public partial interface IIExtensionInterface : ICppClassOverridable<IExtensionInterface> {
			[Virtual] [Inline] uint GetExtensionVersion (CppInstancePtr @this);
			[Virtual] bool OnExtensionLoad (CppInstancePtr @this, SourceMod.IExtension me, SourceMod.IShareSys sys, string error, uint maxlength, bool late);
			[Virtual] void OnExtensionUnload (CppInstancePtr @this);
			[Virtual] void OnExtensionsAllLoaded (CppInstancePtr @this);
			[Virtual] void OnExtensionPauseChange (CppInstancePtr @this, bool pause);
			[Virtual] [Inline] bool QueryInterfaceDrop (CppInstancePtr @this, SourceMod.SMInterface pInterface);
			[Virtual] [Inline] void NotifyInterfaceDrop (CppInstancePtr @this, SourceMod.SMInterface pInterface);
			[Virtual] [Inline] bool QueryRunning (CppInstancePtr @this, string error, uint maxlength);
			[Virtual] bool IsMetamodExtension (CppInstancePtr @this);
			[Virtual] string GetExtensionName (CppInstancePtr @this);
			[Virtual] string GetExtensionURL (CppInstancePtr @this);
			[Virtual] string GetExtensionTag (CppInstancePtr @this);
			[Virtual] string GetExtensionAuthor (CppInstancePtr @this);
			[Virtual] string GetExtensionVerString (CppInstancePtr @this);
			[Virtual] string GetExtensionDescription (CppInstancePtr @this);
			[Virtual] string GetExtensionDateString (CppInstancePtr @this);
			[Virtual] [Inline] void OnCoreMapStart (CppInstancePtr @this, IntPtr pEdictList, int edictCount, int clientMax);
		}
		public unsafe struct _IExtensionInterface {
		}




		public IExtensionInterface (CppTypeInfo subClass)
		{
			__cxxi_LayoutClass ();
			subClass.AddBase (impl.TypeInfo);
		}

		public IExtensionInterface (CppInstancePtr native)
		{
			__cxxi_LayoutClass ();
			Native = native;
		}

		[OverrideNative ("OnExtensionLoad")]
		public virtual bool OnExtensionLoad (SourceMod.IExtension me, SourceMod.IShareSys sys, string error, uint maxlength, bool late)
		{
			return impl.OnExtensionLoad (Native, me, sys, error, maxlength, late);
		}
		[OverrideNative ("OnExtensionUnload")]
		public virtual void OnExtensionUnload ()
		{
			impl.OnExtensionUnload (Native);
		}
		[OverrideNative ("OnExtensionsAllLoaded")]
		public virtual void OnExtensionsAllLoaded ()
		{
			impl.OnExtensionsAllLoaded (Native);
		}
		[OverrideNative ("OnExtensionPauseChange")]
		public virtual void OnExtensionPauseChange (bool pause)
		{
			impl.OnExtensionPauseChange (Native, pause);
		}
		[OverrideNative ("IsMetamodExtension")]
		public virtual bool IsMetamodExtension ()
		{
			return impl.IsMetamodExtension (Native);
		}
		[OverrideNative ("GetExtensionName")]
		public virtual string GetExtensionName ()
		{
			return impl.GetExtensionName (Native);
		}
		[OverrideNative ("GetExtensionURL")]
		public virtual string GetExtensionURL ()
		{
			return impl.GetExtensionURL (Native);
		}
		[OverrideNative ("GetExtensionTag")]
		public virtual string GetExtensionTag ()
		{
			return impl.GetExtensionTag (Native);
		}
		[OverrideNative ("GetExtensionAuthor")]
		public virtual string GetExtensionAuthor ()
		{
			return impl.GetExtensionAuthor (Native);
		}
		[OverrideNative ("GetExtensionVerString")]
		public virtual string GetExtensionVerString ()
		{
			return impl.GetExtensionVerString (Native);
		}
		[OverrideNative ("GetExtensionDescription")]
		public virtual string GetExtensionDescription ()
		{
			return impl.GetExtensionDescription (Native);
		}
		[OverrideNative ("GetExtensionDateString")]
		public virtual string GetExtensionDateString ()
		{
			return impl.GetExtensionDateString (Native);
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

