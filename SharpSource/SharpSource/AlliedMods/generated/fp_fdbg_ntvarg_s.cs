// -------------------------------------------------------------------------
//  Managed wrapper for fp_fdbg_ntvarg_s
//  Generated from bindings.xml on 02/28/2012 15:56:54
//
//  This file was auto generated. Do not edit.
// -------------------------------------------------------------------------

using System;
using Mono.Cxxi;

namespace AlliedMods {
	public partial class fp_fdbg_ntvarg_s : ICppObject {

		private static readonly Ifp_fdbg_ntvarg_s impl = Libs.AlliedMods.GetClass<Ifp_fdbg_ntvarg_s,_fp_fdbg_ntvarg_s,fp_fdbg_ntvarg_s> ("fp_fdbg_ntvarg_s");
		public CppInstancePtr Native { get; protected set; }

		[MangleAs ("struct fp_fdbg_ntvarg_s")]
		public partial interface Ifp_fdbg_ntvarg_s : ICppClassOverridable<fp_fdbg_ntvarg_s> {
			CppField<char> ident { get; }
			CppField<short> tagid { get; }
			CppField<ushort> dimcount { get; }
			CppField<uint> name { get; }
		}
		public unsafe struct _fp_fdbg_ntvarg_s {
			public char ident;
			public short tagid;
			public ushort dimcount;
			public uint name;
		}

		public char ident {
			get {
				return impl.ident [Native];
			}
			set {
				impl.ident [Native] = value;
			}
		}
		public short tagid {
			get {
				return impl.tagid [Native];
			}
			set {
				impl.tagid [Native] = value;
			}
		}
		public ushort dimcount {
			get {
				return impl.dimcount [Native];
			}
			set {
				impl.dimcount [Native] = value;
			}
		}
		public uint name {
			get {
				return impl.name [Native];
			}
			set {
				impl.name [Native] = value;
			}
		}



		public fp_fdbg_ntvarg_s (CppTypeInfo subClass)
		{
			__cxxi_LayoutClass ();
			subClass.AddBase (impl.TypeInfo);
		}

		public fp_fdbg_ntvarg_s (CppInstancePtr native)
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

