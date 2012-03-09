// -------------------------------------------------------------------------
//  Managed wrapper for itimerspec
//  Generated from bindings.xml on 02/28/2012 15:56:54
//
//  This file was auto generated. Do not edit.
// -------------------------------------------------------------------------

using System;
using Mono.Cxxi;

namespace AlliedMods {
	public partial class itimerspec : ICppObject {

		private static readonly Iitimerspec impl = Libs.AlliedMods.GetClass<Iitimerspec,_itimerspec,itimerspec> ("itimerspec");
		public CppInstancePtr Native { get; protected set; }

		[MangleAs ("struct itimerspec")]
		public partial interface Iitimerspec : ICppClassOverridable<itimerspec> {
			CppField<timespec> it_interval { get; }
			CppField<timespec> it_value { get; }
		}
		public unsafe struct _itimerspec {
			public timespec._timespec it_interval;
			public timespec._timespec it_value;
		}

		public timespec it_interval {
			get {
				return impl.it_interval [Native];
			}
			set {
				impl.it_interval [Native] = value;
			}
		}
		public timespec it_value {
			get {
				return impl.it_value [Native];
			}
			set {
				impl.it_value [Native] = value;
			}
		}



		public itimerspec (CppTypeInfo subClass)
		{
			__cxxi_LayoutClass ();
			subClass.AddBase (impl.TypeInfo);
		}

		public itimerspec (CppInstancePtr native)
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

