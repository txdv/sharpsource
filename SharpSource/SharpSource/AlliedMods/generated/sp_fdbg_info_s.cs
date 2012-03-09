// -------------------------------------------------------------------------
//  Managed wrapper for sp_fdbg_info_s
//  Generated from bindings.xml on 02/28/2012 15:56:54
//
//  This file was auto generated. Do not edit.
// -------------------------------------------------------------------------

using System;
using Mono.Cxxi;

namespace AlliedMods {
	public partial class sp_fdbg_info_s : ICppObject {

		private static readonly Isp_fdbg_info_s impl = Libs.AlliedMods.GetClass<Isp_fdbg_info_s,_sp_fdbg_info_s,sp_fdbg_info_s> ("sp_fdbg_info_s");
		public CppInstancePtr Native { get; protected set; }

		[MangleAs ("struct sp_fdbg_info_s")]
		public partial interface Isp_fdbg_info_s : ICppClassOverridable<sp_fdbg_info_s> {
			CppField<uint> num_files { get; }
			CppField<uint> num_lines { get; }
			CppField<uint> num_syms { get; }
			CppField<uint> num_arrays { get; }
		}
		public unsafe struct _sp_fdbg_info_s {
			public uint num_files;
			public uint num_lines;
			public uint num_syms;
			public uint num_arrays;
		}

		public uint num_files {
			get {
				return impl.num_files [Native];
			}
			set {
				impl.num_files [Native] = value;
			}
		}
		public uint num_lines {
			get {
				return impl.num_lines [Native];
			}
			set {
				impl.num_lines [Native] = value;
			}
		}
		public uint num_syms {
			get {
				return impl.num_syms [Native];
			}
			set {
				impl.num_syms [Native] = value;
			}
		}
		public uint num_arrays {
			get {
				return impl.num_arrays [Native];
			}
			set {
				impl.num_arrays [Native] = value;
			}
		}



		public sp_fdbg_info_s (CppTypeInfo subClass)
		{
			__cxxi_LayoutClass ();
			subClass.AddBase (impl.TypeInfo);
		}

		public sp_fdbg_info_s (CppInstancePtr native)
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

