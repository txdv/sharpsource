// -------------------------------------------------------------------------
//  Managed wrapper for sp_file_hdr_s
//  Generated from bindings.xml on 02/28/2012 15:56:54
//
//  This file was auto generated. Do not edit.
// -------------------------------------------------------------------------

using System;
using Mono.Cxxi;

namespace AlliedMods {
	public partial class sp_file_hdr_s : ICppObject {

		private static readonly Isp_file_hdr_s impl = Libs.AlliedMods.GetClass<Isp_file_hdr_s,_sp_file_hdr_s,sp_file_hdr_s> ("sp_file_hdr_s");
		public CppInstancePtr Native { get; protected set; }

		[MangleAs ("struct sp_file_hdr_s")]
		public partial interface Isp_file_hdr_s : ICppClassOverridable<sp_file_hdr_s> {
			CppField<uint> magic { get; }
			CppField<ushort> version { get; }
			CppField<char> compression { get; }
			CppField<uint> disksize { get; }
			CppField<uint> imagesize { get; }
			CppField<char> sections { get; }
			CppField<uint> stringtab { get; }
			CppField<uint> dataoffs { get; }
		}
		public unsafe struct _sp_file_hdr_s {
			public uint magic;
			public ushort version;
			public char compression;
			public uint disksize;
			public uint imagesize;
			public char sections;
			public uint stringtab;
			public uint dataoffs;
		}

		public uint magic {
			get {
				return impl.magic [Native];
			}
			set {
				impl.magic [Native] = value;
			}
		}
		public ushort version {
			get {
				return impl.version [Native];
			}
			set {
				impl.version [Native] = value;
			}
		}
		public char compression {
			get {
				return impl.compression [Native];
			}
			set {
				impl.compression [Native] = value;
			}
		}
		public uint disksize {
			get {
				return impl.disksize [Native];
			}
			set {
				impl.disksize [Native] = value;
			}
		}
		public uint imagesize {
			get {
				return impl.imagesize [Native];
			}
			set {
				impl.imagesize [Native] = value;
			}
		}
		public char sections {
			get {
				return impl.sections [Native];
			}
			set {
				impl.sections [Native] = value;
			}
		}
		public uint stringtab {
			get {
				return impl.stringtab [Native];
			}
			set {
				impl.stringtab [Native] = value;
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



		public sp_file_hdr_s (CppTypeInfo subClass)
		{
			__cxxi_LayoutClass ();
			subClass.AddBase (impl.TypeInfo);
		}

		public sp_file_hdr_s (CppInstancePtr native)
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

