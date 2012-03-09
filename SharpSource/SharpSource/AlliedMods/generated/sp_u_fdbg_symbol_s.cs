// -------------------------------------------------------------------------
//  Managed wrapper for sp_u_fdbg_symbol_s
//  Generated from bindings.xml on 02/28/2012 15:56:54
//
//  This file was auto generated. Do not edit.
// -------------------------------------------------------------------------

using System;
using Mono.Cxxi;

namespace AlliedMods {
	public partial class sp_u_fdbg_symbol_s : ICppObject {

		private static readonly Isp_u_fdbg_symbol_s impl = Libs.AlliedMods.GetClass<Isp_u_fdbg_symbol_s,_sp_u_fdbg_symbol_s,sp_u_fdbg_symbol_s> ("sp_u_fdbg_symbol_s");
		public CppInstancePtr Native { get; protected set; }

		[MangleAs ("struct sp_u_fdbg_symbol_s")]
		public partial interface Isp_u_fdbg_symbol_s : ICppClassOverridable<sp_u_fdbg_symbol_s> {
			CppField<int> addr { get; }
			CppField<short> tagid { get; }
			CppField<uint> codestart { get; }
			CppField<uint> codeend { get; }
			CppField<char> ident { get; }
			CppField<char> vclass { get; }
			CppField<ushort> dimcount { get; }
			CppField<uint> name { get; }
		}
		public unsafe struct _sp_u_fdbg_symbol_s {
			public int addr;
			public short tagid;
			public uint codestart;
			public uint codeend;
			public char ident;
			public char vclass;
			public ushort dimcount;
			public uint name;
		}

		public int addr {
			get {
				return impl.addr [Native];
			}
			set {
				impl.addr [Native] = value;
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
		public char ident {
			get {
				return impl.ident [Native];
			}
			set {
				impl.ident [Native] = value;
			}
		}
		public char vclass {
			get {
				return impl.vclass [Native];
			}
			set {
				impl.vclass [Native] = value;
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



		public sp_u_fdbg_symbol_s (CppTypeInfo subClass)
		{
			__cxxi_LayoutClass ();
			subClass.AddBase (impl.TypeInfo);
		}

		public sp_u_fdbg_symbol_s (CppInstancePtr native)
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

