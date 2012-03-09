// -------------------------------------------------------------------------
//  Managed wrapper for ISourceMod
//  Generated from bindings.xml on 02/28/2012 15:56:54
//
//  This file was auto generated. Do not edit.
// -------------------------------------------------------------------------

using System;
using Mono.Cxxi;

namespace AlliedMods.SourceMod {
	public partial class ISourceMod : SMInterface {

		private static readonly IISourceMod impl = Libs.AlliedMods.GetClass<IISourceMod,_ISourceMod,ISourceMod> ("ISourceMod");

		[MangleAs ("class SourceMod::ISourceMod")]
		public partial interface IISourceMod : ICppClassOverridable<ISourceMod> {
			[Virtual] [Const] string GetGamePath (CppInstancePtr @this);
			[Virtual] [Const] string GetSourceModPath (CppInstancePtr @this);
			[Virtual] uint BuildPath (CppInstancePtr @this, SourceMod.PathType type, IntPtr buffer, uint maxlength, string format);
			[Virtual] void LogMessage (CppInstancePtr @this, SourceMod.IExtension pExt, string format);
			[Virtual] void LogError (CppInstancePtr @this, SourceMod.IExtension pExt, string format);
			[Virtual] uint FormatString (CppInstancePtr @this, string buffer, uint maxlength, SourcePawn.IPluginContext pContext, ref int @params, uint param);
			[Virtual] SourceMod.IDataPack CreateDataPack (CppInstancePtr @this);
			[Virtual] void FreeDataPack (CppInstancePtr @this, SourceMod.IDataPack pack);
			[Virtual] uint GetDataPackHandleType (CppInstancePtr @this, bool @readonly);
			[Virtual] void ReadKeyValuesHandle (CppInstancePtr @this, uint hndl, IntPtr err, bool root);
			[Virtual] [Const] string GetGameFolderName (CppInstancePtr @this);
			[Virtual] SourcePawn.ISourcePawnEngine GetScriptingEngine (CppInstancePtr @this);
			[Virtual] void GetScriptingVM (CppInstancePtr @this);
			[Virtual] int GetAdjustedTime (CppInstancePtr @this);
			[Virtual] uint SetGlobalTarget (CppInstancePtr @this, uint index);
			[Virtual] [Const] uint GetGlobalTarget (CppInstancePtr @this);
			[Virtual] void AddGameFrameHook (CppInstancePtr @this, IntPtr hook);
			[Virtual] void RemoveGameFrameHook (CppInstancePtr @this, IntPtr hook);
			[Virtual] uint Format (CppInstancePtr @this, string buffer, uint maxlength, string fmt);
			[Virtual] uint FormatArgs (CppInstancePtr @this, string buffer, uint maxlength, string fmt, string ap);
			[Virtual] void AddFrameAction (CppInstancePtr @this, IntPtr fn, IntPtr data);
			[Virtual] string GetCoreConfigValue (CppInstancePtr @this, string key);
			[Virtual] int GetPluginId (CppInstancePtr @this);
			[Virtual] int GetShApiVersion (CppInstancePtr @this);
			[Virtual] bool IsMapRunning (CppInstancePtr @this);
		}
		public unsafe struct _ISourceMod {
		}




		public ISourceMod (CppTypeInfo subClass)
			: base (impl.TypeInfo)
		{
			__cxxi_LayoutClass ();
			subClass.AddBase (impl.TypeInfo);
		}

		public ISourceMod (CppInstancePtr native)
			: base (impl.TypeInfo)
		{
			__cxxi_LayoutClass ();
			Native = native;
		}

		[OverrideNative ("BuildPath")]
		public virtual uint BuildPath (SourceMod.PathType type, IntPtr buffer, uint maxlength, string format)
		{
			return impl.BuildPath (Native, type, buffer, maxlength, format);
		}
		[OverrideNative ("LogMessage")]
		public virtual void LogMessage (SourceMod.IExtension pExt, string format)
		{
			impl.LogMessage (Native, pExt, format);
		}
		[OverrideNative ("LogError")]
		public virtual void LogError (SourceMod.IExtension pExt, string format)
		{
			impl.LogError (Native, pExt, format);
		}
		[OverrideNative ("FormatString")]
		public virtual uint FormatString (string buffer, uint maxlength, SourcePawn.IPluginContext pContext, ref int @params, uint param)
		{
			return impl.FormatString (Native, buffer, maxlength, pContext, ref @params, param);
		}
		[OverrideNative ("CreateDataPack")]
		public virtual SourceMod.IDataPack CreateDataPack ()
		{
			return impl.CreateDataPack (Native);
		}
		[OverrideNative ("FreeDataPack")]
		public virtual void FreeDataPack (SourceMod.IDataPack pack)
		{
			impl.FreeDataPack (Native, pack);
		}
		[OverrideNative ("GetDataPackHandleType")]
		public virtual uint GetDataPackHandleType (bool @readonly)
		{
			return impl.GetDataPackHandleType (Native, @readonly);
		}
		[OverrideNative ("GetScriptingEngine")]
		public virtual SourcePawn.ISourcePawnEngine GetScriptingEngine ()
		{
			return impl.GetScriptingEngine (Native);
		}
		[OverrideNative ("GetAdjustedTime")]
		public virtual int GetAdjustedTime ()
		{
			return impl.GetAdjustedTime (Native);
		}
		[OverrideNative ("SetGlobalTarget")]
		public virtual uint SetGlobalTarget (uint index)
		{
			return impl.SetGlobalTarget (Native, index);
		}
		[OverrideNative ("Format")]
		public virtual uint Format (string buffer, uint maxlength, string fmt)
		{
			return impl.Format (Native, buffer, maxlength, fmt);
		}
		[OverrideNative ("FormatArgs")]
		public virtual uint FormatArgs (string buffer, uint maxlength, string fmt, string ap)
		{
			return impl.FormatArgs (Native, buffer, maxlength, fmt, ap);
		}
		[OverrideNative ("GetCoreConfigValue")]
		public virtual string GetCoreConfigValue (string key)
		{
			return impl.GetCoreConfigValue (Native, key);
		}
		[OverrideNative ("GetPluginId")]
		public virtual int GetPluginId ()
		{
			return impl.GetPluginId (Native);
		}
		[OverrideNative ("GetShApiVersion")]
		public virtual int GetShApiVersion ()
		{
			return impl.GetShApiVersion (Native);
		}
		[OverrideNative ("IsMapRunning")]
		public virtual bool IsMapRunning ()
		{
			return impl.IsMapRunning (Native);
		}

		public virtual string GetGamePath {
			[OverrideNative ("GetGamePath")] get {
				return impl.GetGamePath (Native);
			}
		}

		public virtual string GetSourceModPath {
			[OverrideNative ("GetSourceModPath")] get {
				return impl.GetSourceModPath (Native);
			}
		}

		public virtual string GetGameFolderName {
			[OverrideNative ("GetGameFolderName")] get {
				return impl.GetGameFolderName (Native);
			}
		}

		public virtual uint GetGlobalTarget {
			[OverrideNative ("GetGlobalTarget")] get {
				return impl.GetGlobalTarget (Native);
			}
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

