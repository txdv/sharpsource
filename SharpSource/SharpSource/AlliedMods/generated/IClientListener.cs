// -------------------------------------------------------------------------
//  Managed wrapper for IClientListener
//  Generated from bindings.xml on 03/09/2012 13:42:17
//
//  This file was auto generated. Do not edit.
// -------------------------------------------------------------------------

using System;
using Mono.Cxxi;

namespace AlliedMods.SourceMod {
	public partial class IClientListener : ICppObject {

		private static readonly IIClientListener impl = Libs.AlliedMods.GetClass<IIClientListener,_IClientListener,IClientListener> ("IClientListener");
		public CppInstancePtr Native { get; protected set; }

		[MangleAs ("class SourceMod::IClientListener")]
		public partial interface IIClientListener : ICppClassOverridable<IClientListener> {
			[Virtual] [Inline] uint GetClientListenerVersion (CppInstancePtr @this);
			[Virtual] [Inline] bool InterceptClientConnect (CppInstancePtr @this, int client, string error, uint maxlength);
			[Virtual] [Inline] void OnClientConnected (CppInstancePtr @this, int client);
			[Virtual] [Inline] void OnClientPutInServer (CppInstancePtr @this, int client);
			[Virtual] [Inline] void OnClientDisconnecting (CppInstancePtr @this, int client);
			[Virtual] [Inline] void OnClientDisconnected (CppInstancePtr @this, int client);
			[Virtual] [Inline] void OnClientAuthorized (CppInstancePtr @this, int client, string authstring);
			[Virtual] [Inline] void OnServerActivated (CppInstancePtr @this, int max_clients);
			[Virtual] [Inline] bool OnClientPreAdminCheck (CppInstancePtr @this, int client);
			[Virtual] [Inline] void OnClientPostAdminCheck (CppInstancePtr @this, int client);
			[Virtual] [Inline] void OnMaxPlayersChanged (CppInstancePtr @this, int newvalue);
			[Virtual] [Inline] void OnClientSettingsChanged (CppInstancePtr @this, int client);
		}
		public unsafe struct _IClientListener {
		}




		public IClientListener (CppTypeInfo subClass)
		{
			__cxxi_LayoutClass ();
			subClass.AddBase (impl.TypeInfo);
		}

		public IClientListener (CppInstancePtr native)
		{
			__cxxi_LayoutClass ();
			Native = native;
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

