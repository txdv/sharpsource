// -------------------------------------------------------------------------
//  Managed wrapper for Dl_serinfo
//  Generated from bindings.xml on 02/28/2012 15:56:54
//
//  This file was auto generated. Do not edit.
// -------------------------------------------------------------------------

using System;
using Mono.Cxxi;

namespace AlliedMods {
	public partial class Dl_serinfo : ICppObject {

		private static readonly IDl_serinfo impl = Libs.AlliedMods.GetClass<IDl_serinfo,_Dl_serinfo,Dl_serinfo> ("Dl_serinfo");
		public CppInstancePtr Native { get; protected set; }

		[MangleAs ("struct Dl_serinfo")]
		public partial interface IDl_serinfo : ICppClassOverridable<Dl_serinfo> {
			CppField<uint> dls_size { get; }
			CppField<uint> dls_cnt { get; }
			CppField<Dl_serpath> dls_serpath { get; }
		}
		public unsafe struct _Dl_serinfo {
			public uint dls_size;
			public uint dls_cnt;
			public Dl_serpath dls_serpath;
		}

		public uint dls_size {
			get {
				return impl.dls_size [Native];
			}
			set {
				impl.dls_size [Native] = value;
			}
		}
		public uint dls_cnt {
			get {
				return impl.dls_cnt [Native];
			}
			set {
				impl.dls_cnt [Native] = value;
			}
		}
		public Dl_serpath dls_serpath {
			get {
				return impl.dls_serpath [Native];
			}
			set {
				impl.dls_serpath [Native] = value;
			}
		}



		public Dl_serinfo (CppTypeInfo subClass)
		{
			__cxxi_LayoutClass ();
			subClass.AddBase (impl.TypeInfo);
		}

		public Dl_serinfo (CppInstancePtr native)
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

