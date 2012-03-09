// -------------------------------------------------------------------------
//  Managed wrapper for sp_fdbg_native_s
//  Generated from bindings.xml on 02/28/2012 15:56:54
//
//  This file was auto generated. Do not edit.
// -------------------------------------------------------------------------

using System;
using Mono.Cxxi;

namespace AlliedMods {
	public partial class sp_fdbg_native_s : ICppObject {

		private static readonly Isp_fdbg_native_s impl = Libs.AlliedMods.GetClass<Isp_fdbg_native_s,_sp_fdbg_native_s,sp_fdbg_native_s> ("sp_fdbg_native_s");
		public CppInstancePtr Native { get; protected set; }

		[MangleAs ("struct sp_fdbg_native_s")]
		public partial interface Isp_fdbg_native_s : ICppClassOverridable<sp_fdbg_native_s> {
			CppField<uint> index { get; }
			CppField<uint> name { get; }
			CppField<short> tagid { get; }
			CppField<ushort> nargs { get; }
		}
		public unsafe struct _sp_fdbg_native_s {
			public uint index;
			public uint name;
			public short tagid;
			public ushort nargs;
		}

		public uint index {
			get {
				return impl.index [Native];
			}
			set {
				impl.index [Native] = value;
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
		public short tagid {
			get {
				return impl.tagid [Native];
			}
			set {
				impl.tagid [Native] = value;
			}
		}
		public ushort nargs {
			get {
				return impl.nargs [Native];
			}
			set {
				impl.nargs [Native] = value;
			}
		}



		public sp_fdbg_native_s (CppTypeInfo subClass)
		{
			__cxxi_LayoutClass ();
			subClass.AddBase (impl.TypeInfo);
		}

		public sp_fdbg_native_s (CppInstancePtr native)
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

