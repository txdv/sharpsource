// -------------------------------------------------------------------------
//  Managed wrapper for sp_file_data_s
//  Generated from bindings.xml on 02/28/2012 15:56:54
//
//  This file was auto generated. Do not edit.
// -------------------------------------------------------------------------

using System;
using Mono.Cxxi;

namespace AlliedMods {
	public partial class sp_file_data_s : ICppObject {

		private static readonly Isp_file_data_s impl = Libs.AlliedMods.GetClass<Isp_file_data_s,_sp_file_data_s,sp_file_data_s> ("sp_file_data_s");
		public CppInstancePtr Native { get; protected set; }

		[MangleAs ("struct sp_file_data_s")]
		public partial interface Isp_file_data_s : ICppClassOverridable<sp_file_data_s> {
			CppField<uint> datasize { get; }
			CppField<uint> memsize { get; }
			CppField<uint> data { get; }
		}
		public unsafe struct _sp_file_data_s {
			public uint datasize;
			public uint memsize;
			public uint data;
		}

		public uint datasize {
			get {
				return impl.datasize [Native];
			}
			set {
				impl.datasize [Native] = value;
			}
		}
		public uint memsize {
			get {
				return impl.memsize [Native];
			}
			set {
				impl.memsize [Native] = value;
			}
		}
		public uint data {
			get {
				return impl.data [Native];
			}
			set {
				impl.data [Native] = value;
			}
		}



		public sp_file_data_s (CppTypeInfo subClass)
		{
			__cxxi_LayoutClass ();
			subClass.AddBase (impl.TypeInfo);
		}

		public sp_file_data_s (CppInstancePtr native)
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

