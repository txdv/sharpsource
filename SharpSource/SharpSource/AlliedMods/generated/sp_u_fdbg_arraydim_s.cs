// -------------------------------------------------------------------------
//  Managed wrapper for sp_u_fdbg_arraydim_s
//  Generated from bindings.xml on 02/28/2012 15:56:54
//
//  This file was auto generated. Do not edit.
// -------------------------------------------------------------------------

using System;
using Mono.Cxxi;

namespace AlliedMods {
	public partial class sp_u_fdbg_arraydim_s : ICppObject {

		private static readonly Isp_u_fdbg_arraydim_s impl = Libs.AlliedMods.GetClass<Isp_u_fdbg_arraydim_s,_sp_u_fdbg_arraydim_s,sp_u_fdbg_arraydim_s> ("sp_u_fdbg_arraydim_s");
		public CppInstancePtr Native { get; protected set; }

		[MangleAs ("struct sp_u_fdbg_arraydim_s")]
		public partial interface Isp_u_fdbg_arraydim_s : ICppClassOverridable<sp_u_fdbg_arraydim_s> {
			CppField<short> tagid { get; }
			CppField<uint> size { get; }
		}
		public unsafe struct _sp_u_fdbg_arraydim_s {
			public short tagid;
			public uint size;
		}

		public short tagid {
			get {
				return impl.tagid [Native];
			}
			set {
				impl.tagid [Native] = value;
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



		public sp_u_fdbg_arraydim_s (CppTypeInfo subClass)
		{
			__cxxi_LayoutClass ();
			subClass.AddBase (impl.TypeInfo);
		}

		public sp_u_fdbg_arraydim_s (CppInstancePtr native)
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

