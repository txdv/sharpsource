// -------------------------------------------------------------------------
//  Managed wrapper for tm
//  Generated from bindings.xml on 02/28/2012 15:56:54
//
//  This file was auto generated. Do not edit.
// -------------------------------------------------------------------------

using System;
using Mono.Cxxi;

namespace AlliedMods {
	public partial class tm : ICppObject {

		private static readonly Itm impl = Libs.AlliedMods.GetClass<Itm,_tm,tm> ("tm");
		public CppInstancePtr Native { get; protected set; }

		[MangleAs ("struct tm")]
		public partial interface Itm : ICppClassOverridable<tm> {
			CppField<int> tm_sec { get; }
			CppField<int> tm_min { get; }
			CppField<int> tm_hour { get; }
			CppField<int> tm_mday { get; }
			CppField<int> tm_mon { get; }
			CppField<int> tm_year { get; }
			CppField<int> tm_wday { get; }
			CppField<int> tm_yday { get; }
			CppField<int> tm_isdst { get; }
			CppField<int> tm_gmtoff { get; }
			CppField<string> tm_zone { get; }
		}
		public unsafe struct _tm {
			public int tm_sec;
			public int tm_min;
			public int tm_hour;
			public int tm_mday;
			public int tm_mon;
			public int tm_year;
			public int tm_wday;
			public int tm_yday;
			public int tm_isdst;
			public int tm_gmtoff;
			public string tm_zone;
		}

		public int tm_sec {
			get {
				return impl.tm_sec [Native];
			}
			set {
				impl.tm_sec [Native] = value;
			}
		}
		public int tm_min {
			get {
				return impl.tm_min [Native];
			}
			set {
				impl.tm_min [Native] = value;
			}
		}
		public int tm_hour {
			get {
				return impl.tm_hour [Native];
			}
			set {
				impl.tm_hour [Native] = value;
			}
		}
		public int tm_mday {
			get {
				return impl.tm_mday [Native];
			}
			set {
				impl.tm_mday [Native] = value;
			}
		}
		public int tm_mon {
			get {
				return impl.tm_mon [Native];
			}
			set {
				impl.tm_mon [Native] = value;
			}
		}
		public int tm_year {
			get {
				return impl.tm_year [Native];
			}
			set {
				impl.tm_year [Native] = value;
			}
		}
		public int tm_wday {
			get {
				return impl.tm_wday [Native];
			}
			set {
				impl.tm_wday [Native] = value;
			}
		}
		public int tm_yday {
			get {
				return impl.tm_yday [Native];
			}
			set {
				impl.tm_yday [Native] = value;
			}
		}
		public int tm_isdst {
			get {
				return impl.tm_isdst [Native];
			}
			set {
				impl.tm_isdst [Native] = value;
			}
		}
		public int tm_gmtoff {
			get {
				return impl.tm_gmtoff [Native];
			}
			set {
				impl.tm_gmtoff [Native] = value;
			}
		}
		public string tm_zone {
			get {
				return impl.tm_zone [Native];
			}
			set {
				impl.tm_zone [Native] = value;
			}
		}



		public tm (CppTypeInfo subClass)
		{
			__cxxi_LayoutClass ();
			subClass.AddBase (impl.TypeInfo);
		}

		public tm (CppInstancePtr native)
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

