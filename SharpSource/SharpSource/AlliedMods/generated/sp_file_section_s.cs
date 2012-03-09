// -------------------------------------------------------------------------
//  Managed wrapper for sp_file_section_s
//  Generated from bindings.xml on 02/28/2012 15:56:54
//
//  This file was auto generated. Do not edit.
// -------------------------------------------------------------------------

using System;
using Mono.Cxxi;

namespace AlliedMods {
	public partial class sp_file_section_s : ICppObject {

		private static readonly Isp_file_section_s impl = Libs.AlliedMods.GetClass<Isp_file_section_s,_sp_file_section_s,sp_file_section_s> ("sp_file_section_s");
		public CppInstancePtr Native { get; protected set; }

		[MangleAs ("struct sp_file_section_s")]
		public partial interface Isp_file_section_s : ICppClassOverridable<sp_file_section_s> {
			CppField<uint> nameoffs { get; }
			CppField<uint> dataoffs { get; }
			CppField<uint> size { get; }
		}
		public unsafe struct _sp_file_section_s {
			public uint nameoffs;
			public uint dataoffs;
			public uint size;
		}

		public uint nameoffs {
			get {
				return impl.nameoffs [Native];
			}
			set {
				impl.nameoffs [Native] = value;
			}
		}
		public uint dataoffs {
			get {
				return impl.dataoffs [Native];
			}
			set {
				impl.dataoffs [Native] = value;
			}
		}
		public uint size {
			get {
				return impl.size [Native];
			}
			set {
				impl.size [Native] = value;
			}
		}



		public sp_file_section_s (CppTypeInfo subClass)
		{
			__cxxi_LayoutClass ();
			subClass.AddBase (impl.TypeInfo);
		}

		public sp_file_section_s (CppInstancePtr native)
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

