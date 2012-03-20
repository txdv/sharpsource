// -------------------------------------------------------------------------
//  Managed wrapper for IMapTimer
//  Generated from bindings.xml on 03/09/2012 13:42:17
//
//  This file was auto generated. Do not edit.
// -------------------------------------------------------------------------

using System;
using Mono.Cxxi;

namespace AlliedMods.SourceMod {
	public partial class IMapTimer : ICppObject {

		private static readonly IIMapTimer impl = Libs.AlliedMods.GetClass<IIMapTimer,_IMapTimer,IMapTimer> ("IMapTimer");
		public CppInstancePtr Native { get; protected set; }

		[MangleAs ("class SourceMod::IMapTimer")]
		public partial interface IIMapTimer : ICppClassOverridable<IMapTimer> {
			[Virtual] int GetMapTimeLimit (CppInstancePtr @this);
			[Virtual] void ExtendMapTimeLimit (CppInstancePtr @this, int extra_time);
			[Virtual] void SetMapTimerStatus (CppInstancePtr @this, bool enabled);
		}
		public unsafe struct _IMapTimer {
		}




		public IMapTimer (CppTypeInfo subClass)
		{
			__cxxi_LayoutClass ();
			subClass.AddBase (impl.TypeInfo);
		}

		public IMapTimer (CppInstancePtr native)
		{
			__cxxi_LayoutClass ();
			Native = native;
		}

		[OverrideNative ("GetMapTimeLimit")]
		public virtual int GetMapTimeLimit ()
		{
			return impl.GetMapTimeLimit (Native);
		}
		[OverrideNative ("ExtendMapTimeLimit")]
		public virtual void ExtendMapTimeLimit (int extra_time)
		{
			impl.ExtendMapTimeLimit (Native, extra_time);
		}
		[OverrideNative ("SetMapTimerStatus")]
		public virtual void SetMapTimerStatus (bool enabled)
		{
			impl.SetMapTimerStatus (Native, enabled);
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

