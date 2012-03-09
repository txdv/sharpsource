// -------------------------------------------------------------------------
//  Managed wrapper for sp_file_tag_s
//  Generated from bindings.xml on 02/28/2012 15:56:54
//
//  This file was auto generated. Do not edit.
// -------------------------------------------------------------------------

using System;
using Mono.Cxxi;

namespace AlliedMods {
	public partial class sp_file_tag_s : ICppObject {

		private static readonly Isp_file_tag_s impl = Libs.AlliedMods.GetClass<Isp_file_tag_s,_sp_file_tag_s,sp_file_tag_s> ("sp_file_tag_s");
		public CppInstancePtr Native { get; protected set; }

		[MangleAs ("struct sp_file_tag_s")]
		public partial interface Isp_file_tag_s : ICppClassOverridable<sp_file_tag_s> {
			CppField<uint> tag_id { get; }
			CppField<uint> name { get; }
		}
		public unsafe struct _sp_file_tag_s {
			public uint tag_id;
			public uint name;
		}

		public uint tag_id {
			get {
				return impl.tag_id [Native];
			}
			set {
				impl.tag_id [Native] = value;
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



		public sp_file_tag_s (CppTypeInfo subClass)
		{
			__cxxi_LayoutClass ();
			subClass.AddBase (impl.TypeInfo);
		}

		public sp_file_tag_s (CppInstancePtr native)
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

