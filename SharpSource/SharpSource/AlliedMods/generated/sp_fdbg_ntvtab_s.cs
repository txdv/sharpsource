// -------------------------------------------------------------------------
//  Managed wrapper for sp_fdbg_ntvtab_s
//  Generated from bindings.xml on 02/28/2012 15:56:54
//
//  This file was auto generated. Do not edit.
// -------------------------------------------------------------------------

using System;
using Mono.Cxxi;

namespace AlliedMods {
	public partial class sp_fdbg_ntvtab_s : ICppObject {

		private static readonly Isp_fdbg_ntvtab_s impl = Libs.AlliedMods.GetClass<Isp_fdbg_ntvtab_s,_sp_fdbg_ntvtab_s,sp_fdbg_ntvtab_s> ("sp_fdbg_ntvtab_s");
		public CppInstancePtr Native { get; protected set; }

		[MangleAs ("struct sp_fdbg_ntvtab_s")]
		public partial interface Isp_fdbg_ntvtab_s : ICppClassOverridable<sp_fdbg_ntvtab_s> {
			CppField<uint> num_entries { get; }
		}
		public unsafe struct _sp_fdbg_ntvtab_s {
			public uint num_entries;
		}

		public uint num_entries {
			get {
				return impl.num_entries [Native];
			}
			set {
				impl.num_entries [Native] = value;
			}
		}



		public sp_fdbg_ntvtab_s (CppTypeInfo subClass)
		{
			__cxxi_LayoutClass ();
			subClass.AddBase (impl.TypeInfo);
		}

		public sp_fdbg_ntvtab_s (CppInstancePtr native)
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

