// -------------------------------------------------------------------------
//  Managed wrapper for ITimerSystem
//  Generated from bindings.xml on 03/09/2012 13:42:17
//
//  This file was auto generated. Do not edit.
// -------------------------------------------------------------------------

using System;
using Mono.Cxxi;

namespace AlliedMods.SourceMod {
	public partial class ITimerSystem : SMInterface {

		private static readonly IITimerSystem impl = Libs.AlliedMods.GetClass<IITimerSystem,_ITimerSystem,ITimerSystem> ("ITimerSystem");

		[MangleAs ("class SourceMod::ITimerSystem")]
		public partial interface IITimerSystem : ICppClassOverridable<ITimerSystem> {
			[Virtual] void CreateTimer (CppInstancePtr @this, SourceMod.ITimedEvent pCallbacks, float fInterval, IntPtr pData, int flags);
			[Virtual] void KillTimer (CppInstancePtr @this, IntPtr pTimer);
			[Virtual] void FireTimerOnce (CppInstancePtr @this, IntPtr pTimer, bool delayExec);
			[Virtual] SourceMod.IMapTimer SetMapTimer (CppInstancePtr @this, SourceMod.IMapTimer pTimer);
			[Virtual] void MapTimeLeftChanged (CppInstancePtr @this);
			[Virtual] float GetTickedTime (CppInstancePtr @this);
			[Virtual] void NotifyOfGameStart (CppInstancePtr @this, float offset);
			[Virtual] bool GetMapTimeLeft (CppInstancePtr @this, ref float pTime);
			[Virtual] SourceMod.IMapTimer GetMapTimer (CppInstancePtr @this);
		}
		public unsafe struct _ITimerSystem {
		}




		public ITimerSystem (CppTypeInfo subClass)
			: base (impl.TypeInfo)
		{
			__cxxi_LayoutClass ();
			subClass.AddBase (impl.TypeInfo);
		}

		public ITimerSystem (CppInstancePtr native)
			: base (impl.TypeInfo)
		{
			__cxxi_LayoutClass ();
			Native = native;
		}

		[OverrideNative ("SetMapTimer")]
		public virtual SourceMod.IMapTimer SetMapTimer (SourceMod.IMapTimer pTimer)
		{
			return impl.SetMapTimer (Native, pTimer);
		}
		[OverrideNative ("MapTimeLeftChanged")]
		public virtual void MapTimeLeftChanged ()
		{
			impl.MapTimeLeftChanged (Native);
		}
		[OverrideNative ("GetTickedTime")]
		public virtual float GetTickedTime ()
		{
			return impl.GetTickedTime (Native);
		}
		[OverrideNative ("NotifyOfGameStart")]
		public virtual void NotifyOfGameStart (float offset)
		{
			impl.NotifyOfGameStart (Native, offset);
		}
		[OverrideNative ("GetMapTimeLeft")]
		public virtual bool GetMapTimeLeft (ref float pTime)
		{
			return impl.GetMapTimeLeft (Native, ref pTime);
		}
		[OverrideNative ("GetMapTimer")]
		public virtual SourceMod.IMapTimer GetMapTimer ()
		{
			return impl.GetMapTimer (Native);
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

