// -------------------------------------------------------------------------
//  Managed wrapper for ITimedEvent
//  Generated from bindings.xml on 03/09/2012 13:42:17
//
//  This file was auto generated. Do not edit.
// -------------------------------------------------------------------------

using System;
using Mono.Cxxi;

namespace AlliedMods.SourceMod {
	public partial class ITimedEvent : ICppObject {

		private static readonly IITimedEvent impl = Libs.AlliedMods.GetClass<IITimedEvent,_ITimedEvent,ITimedEvent> ("ITimedEvent");
		public CppInstancePtr Native { get; protected set; }

		[MangleAs ("class SourceMod::ITimedEvent")]
		public partial interface IITimedEvent : ICppClassOverridable<ITimedEvent> {
			[Virtual] SourceMod.ResultType OnTimer (CppInstancePtr @this, IntPtr pTimer, IntPtr pData);
			[Virtual] void OnTimerEnd (CppInstancePtr @this, IntPtr pTimer, IntPtr pData);
		}
		public unsafe struct _ITimedEvent {
		}




		public ITimedEvent (CppTypeInfo subClass)
		{
			__cxxi_LayoutClass ();
			subClass.AddBase (impl.TypeInfo);
		}

		public ITimedEvent (CppInstancePtr native)
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

