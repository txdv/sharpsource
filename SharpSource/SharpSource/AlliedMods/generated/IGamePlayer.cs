// -------------------------------------------------------------------------
//  Managed wrapper for IGamePlayer
//  Generated from bindings.xml on 03/09/2012 13:42:17
//
//  This file was auto generated. Do not edit.
// -------------------------------------------------------------------------

using System;
using Mono.Cxxi;

namespace AlliedMods.SourceMod {
	public partial class IGamePlayer : ICppObject {

		private static readonly IIGamePlayer impl = Libs.AlliedMods.GetClass<IIGamePlayer,_IGamePlayer,IGamePlayer> ("IGamePlayer");
		public CppInstancePtr Native { get; protected set; }

		[MangleAs ("class SourceMod::IGamePlayer")]
		public partial interface IIGamePlayer : ICppClassOverridable<IGamePlayer> {
			[Virtual] string GetName (CppInstancePtr @this);
			[Virtual] string GetIPAddress (CppInstancePtr @this);
			[Virtual] string GetAuthString (CppInstancePtr @this);
			[Virtual] void GetEdict (CppInstancePtr @this);
			[Virtual] bool IsInGame (CppInstancePtr @this);
			[Virtual] bool IsConnected (CppInstancePtr @this);
			[Virtual] bool IsFakeClient (CppInstancePtr @this);
			[Virtual] int GetAdminId (CppInstancePtr @this);
			[Virtual] void SetAdminId (CppInstancePtr @this, int id, bool temp);
			[Virtual] int GetUserId (CppInstancePtr @this);
			[Virtual] uint GetLanguageId (CppInstancePtr @this);
			[Virtual] void GetPlayerInfo (CppInstancePtr @this);
			[Virtual] bool RunAdminCacheChecks (CppInstancePtr @this);
			[Virtual] void NotifyPostAdminChecks (CppInstancePtr @this);
			[Virtual] uint GetSerial (CppInstancePtr @this);
			[Virtual] bool IsAuthorized (CppInstancePtr @this);
			[Virtual] void Kick (CppInstancePtr @this, string message);
			[Virtual] bool IsInKickQueue (CppInstancePtr @this);
			[Virtual] void MarkAsBeingKicked (CppInstancePtr @this);
			[Virtual] void SetLanguageId (CppInstancePtr @this, uint id);
			[Virtual] [Const] bool IsSourceTV (CppInstancePtr @this);
			[Virtual] [Const] bool IsReplay (CppInstancePtr @this);
		}
		public unsafe struct _IGamePlayer {
		}




		public IGamePlayer (CppTypeInfo subClass)
		{
			__cxxi_LayoutClass ();
			subClass.AddBase (impl.TypeInfo);
		}

		public IGamePlayer (CppInstancePtr native)
		{
			__cxxi_LayoutClass ();
			Native = native;
		}

		[OverrideNative ("GetName")]
		public virtual string GetName ()
		{
			return impl.GetName (Native);
		}
		[OverrideNative ("GetIPAddress")]
		public virtual string GetIPAddress ()
		{
			return impl.GetIPAddress (Native);
		}
		[OverrideNative ("GetAuthString")]
		public virtual string GetAuthString ()
		{
			return impl.GetAuthString (Native);
		}
		[OverrideNative ("IsInGame")]
		public virtual bool IsInGame ()
		{
			return impl.IsInGame (Native);
		}
		[OverrideNative ("IsConnected")]
		public virtual bool IsConnected ()
		{
			return impl.IsConnected (Native);
		}
		[OverrideNative ("IsFakeClient")]
		public virtual bool IsFakeClient ()
		{
			return impl.IsFakeClient (Native);
		}
		[OverrideNative ("GetAdminId")]
		public virtual int GetAdminId ()
		{
			return impl.GetAdminId (Native);
		}
		[OverrideNative ("SetAdminId")]
		public virtual void SetAdminId (int id, bool temp)
		{
			impl.SetAdminId (Native, id, temp);
		}
		[OverrideNative ("GetUserId")]
		public virtual int GetUserId ()
		{
			return impl.GetUserId (Native);
		}
		[OverrideNative ("GetLanguageId")]
		public virtual uint GetLanguageId ()
		{
			return impl.GetLanguageId (Native);
		}
		[OverrideNative ("RunAdminCacheChecks")]
		public virtual bool RunAdminCacheChecks ()
		{
			return impl.RunAdminCacheChecks (Native);
		}
		[OverrideNative ("NotifyPostAdminChecks")]
		public virtual void NotifyPostAdminChecks ()
		{
			impl.NotifyPostAdminChecks (Native);
		}
		[OverrideNative ("GetSerial")]
		public virtual uint GetSerial ()
		{
			return impl.GetSerial (Native);
		}
		[OverrideNative ("IsAuthorized")]
		public virtual bool IsAuthorized ()
		{
			return impl.IsAuthorized (Native);
		}
		[OverrideNative ("Kick")]
		public virtual void Kick (string message)
		{
			impl.Kick (Native, message);
		}
		[OverrideNative ("IsInKickQueue")]
		public virtual bool IsInKickQueue ()
		{
			return impl.IsInKickQueue (Native);
		}
		[OverrideNative ("MarkAsBeingKicked")]
		public virtual void MarkAsBeingKicked ()
		{
			impl.MarkAsBeingKicked (Native);
		}
		[OverrideNative ("SetLanguageId")]
		public virtual void SetLanguageId (uint id)
		{
			impl.SetLanguageId (Native, id);
		}

		public virtual bool IsSourceTV {
			[OverrideNative ("IsSourceTV")] get {
				return impl.IsSourceTV (Native);
			}
		}

		public virtual bool IsReplay {
			[OverrideNative ("IsReplay")] get {
				return impl.IsReplay (Native);
			}
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

