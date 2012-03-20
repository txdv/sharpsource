// -------------------------------------------------------------------------
//  Managed wrapper for IPlayerManager
//  Generated from bindings.xml on 03/09/2012 13:42:17
//
//  This file was auto generated. Do not edit.
// -------------------------------------------------------------------------

using System;
using Mono.Cxxi;

namespace AlliedMods.SourceMod {
	public partial class IPlayerManager : SMInterface {

		private static readonly IIPlayerManager impl = Libs.AlliedMods.GetClass<IIPlayerManager,_IPlayerManager,IPlayerManager> ("IPlayerManager");

		[MangleAs ("class SourceMod::IPlayerManager")]
		public partial interface IIPlayerManager : ICppClassOverridable<IPlayerManager> {
			[Virtual] void AddClientListener (CppInstancePtr @this, SourceMod.IClientListener listener);
			[Virtual] void RemoveClientListener (CppInstancePtr @this, SourceMod.IClientListener listener);
			[Virtual] SourceMod.IGamePlayer GetGamePlayer (CppInstancePtr @this, int client);
			[Virtual] SourceMod.IGamePlayer GetGamePlayer (CppInstancePtr @this, IntPtr pEdict);
			[Virtual] int GetMaxClients (CppInstancePtr @this);
			[Virtual] int GetNumPlayers (CppInstancePtr @this);
			[Virtual] int GetClientOfUserId (CppInstancePtr @this, int userid);
			[Virtual] bool IsServerActivated (CppInstancePtr @this);
			[Virtual] uint GetReplyTo (CppInstancePtr @this);
			[Virtual] uint SetReplyTo (CppInstancePtr @this, uint reply);
			[Virtual] int FilterCommandTarget (CppInstancePtr @this, SourceMod.IGamePlayer pAdmin, SourceMod.IGamePlayer pTarget, int flags);
			[Virtual] void RegisterCommandTargetProcessor (CppInstancePtr @this, SourceMod.ICommandTargetProcessor pHandler);
			[Virtual] void UnregisterCommandTargetProcessor (CppInstancePtr @this, SourceMod.ICommandTargetProcessor pHandler);
			[Virtual] int GetClientFromSerial (CppInstancePtr @this, uint serial);
			[Virtual] void ProcessCommandTarget (CppInstancePtr @this, SourceMod.cmd_target_info_t info);
		}
		public unsafe struct _IPlayerManager {
		}




		public IPlayerManager (CppTypeInfo subClass)
			: base (impl.TypeInfo)
		{
			__cxxi_LayoutClass ();
			subClass.AddBase (impl.TypeInfo);
		}

		public IPlayerManager (CppInstancePtr native)
			: base (impl.TypeInfo)
		{
			__cxxi_LayoutClass ();
			Native = native;
		}

		[OverrideNative ("AddClientListener")]
		public virtual void AddClientListener (SourceMod.IClientListener listener)
		{
			impl.AddClientListener (Native, listener);
		}
		[OverrideNative ("RemoveClientListener")]
		public virtual void RemoveClientListener (SourceMod.IClientListener listener)
		{
			impl.RemoveClientListener (Native, listener);
		}
		[OverrideNative ("GetGamePlayer")]
		public virtual SourceMod.IGamePlayer GetGamePlayer (int client)
		{
			return impl.GetGamePlayer (Native, client);
		}
		[OverrideNative ("GetMaxClients")]
		public virtual int GetMaxClients ()
		{
			return impl.GetMaxClients (Native);
		}
		[OverrideNative ("GetNumPlayers")]
		public virtual int GetNumPlayers ()
		{
			return impl.GetNumPlayers (Native);
		}
		[OverrideNative ("GetClientOfUserId")]
		public virtual int GetClientOfUserId (int userid)
		{
			return impl.GetClientOfUserId (Native, userid);
		}
		[OverrideNative ("IsServerActivated")]
		public virtual bool IsServerActivated ()
		{
			return impl.IsServerActivated (Native);
		}
		[OverrideNative ("GetReplyTo")]
		public virtual uint GetReplyTo ()
		{
			return impl.GetReplyTo (Native);
		}
		[OverrideNative ("SetReplyTo")]
		public virtual uint SetReplyTo (uint reply)
		{
			return impl.SetReplyTo (Native, reply);
		}
		[OverrideNative ("FilterCommandTarget")]
		public virtual int FilterCommandTarget (SourceMod.IGamePlayer pAdmin, SourceMod.IGamePlayer pTarget, int flags)
		{
			return impl.FilterCommandTarget (Native, pAdmin, pTarget, flags);
		}
		[OverrideNative ("RegisterCommandTargetProcessor")]
		public virtual void RegisterCommandTargetProcessor (SourceMod.ICommandTargetProcessor pHandler)
		{
			impl.RegisterCommandTargetProcessor (Native, pHandler);
		}
		[OverrideNative ("UnregisterCommandTargetProcessor")]
		public virtual void UnregisterCommandTargetProcessor (SourceMod.ICommandTargetProcessor pHandler)
		{
			impl.UnregisterCommandTargetProcessor (Native, pHandler);
		}
		[OverrideNative ("GetClientFromSerial")]
		public virtual int GetClientFromSerial (uint serial)
		{
			return impl.GetClientFromSerial (Native, serial);
		}
		[OverrideNative ("ProcessCommandTarget")]
		public virtual void ProcessCommandTarget (SourceMod.cmd_target_info_t info)
		{
			impl.ProcessCommandTarget (Native, info);
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

