// -------------------------------------------------------------------------
//  Managed wrapper for timespec
//  Generated from bindings.xml on 02/28/2012 15:56:54
//
//  This file was auto generated. Do not edit.
// -------------------------------------------------------------------------

using System;
using Mono.Cxxi;

namespace AlliedMods {
	public partial class timespec : ICppObject {

		private static readonly Itimespec impl = Libs.AlliedMods.GetClass<Itimespec,_timespec,timespec> ("timespec");
		public CppInstancePtr Native { get; protected set; }

		[MangleAs ("struct timespec")]
		public partial interface Itimespec : ICppClassOverridable<timespec> {
			CppField<int> tv_sec { get; }
			CppField<int> tv_nsec { get; }
		}
		public unsafe struct _timespec {
			public int tv_sec;
			public int tv_nsec;
		}

		public int tv_sec {
			get {
				return impl.tv_sec [Native];
			}
			set {
				impl.tv_sec [Native] = value;
			}
		}
		public int tv_nsec {
			get {
				return impl.tv_nsec [Native];
			}
			set {
				impl.tv_nsec [Native] = value;
			}
		}



		public timespec (CppTypeInfo subClass)
		{
			__cxxi_LayoutClass ();
			subClass.AddBase (impl.TypeInfo);
		}

		public timespec (CppInstancePtr native)
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

