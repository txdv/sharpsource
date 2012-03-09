// -------------------------------------------------------------------------
//  Managed wrapper for sp_debug_symbol_s
//  Generated from bindings.xml on 02/28/2012 15:56:54
//
//  This file was auto generated. Do not edit.
// -------------------------------------------------------------------------

using System;
using Mono.Cxxi;

namespace AlliedMods {
	public partial class sp_debug_symbol_s : ICppObject {

		private static readonly Isp_debug_symbol_s impl = Libs.AlliedMods.GetClass<Isp_debug_symbol_s,_sp_debug_symbol_s,sp_debug_symbol_s> ("sp_debug_symbol_s");
		public CppInstancePtr Native { get; protected set; }

		[MangleAs ("struct sp_debug_symbol_s")]
		public partial interface Isp_debug_symbol_s : ICppClassOverridable<sp_debug_symbol_s> {
			CppField<uint> codestart { get; }
			CppField<uint> codeend { get; }
			CppField<string> name { get; }
			CppField<sp_fdbg_arraydim_s> dims { get; }
			CppField<sp_fdbg_symbol_s> sym { get; }
		}
		public unsafe struct _sp_debug_symbol_s {
			public uint codestart;
			public uint codeend;
			public string name;
			public sp_fdbg_arraydim_s dims;
			public sp_fdbg_symbol_s sym;
		}

		public uint codestart {
			get {
				return impl.codestart [Native];
			}
			set {
				impl.codestart [Native] = value;
			}
		}
		public uint codeend {
			get {
				return impl.codeend [Native];
			}
			set {
				impl.codeend [Native] = value;
			}
		}
		public string name {
			get {
				return impl.name [Native];
			}
			set {
				impl.name [Native] = value;
			}
		}
		public sp_fdbg_arraydim_s dims {
			get {
				return impl.dims [Native];
			}
			set {
				impl.dims [Native] = value;
			}
		}
		public sp_fdbg_symbol_s sym {
			get {
				return impl.sym [Native];
			}
			set {
				impl.sym [Native] = value;
			}
		}



		public sp_debug_symbol_s (CppTypeInfo subClass)
		{
			__cxxi_LayoutClass ();
			subClass.AddBase (impl.TypeInfo);
		}

		public sp_debug_symbol_s (CppInstancePtr native)
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

