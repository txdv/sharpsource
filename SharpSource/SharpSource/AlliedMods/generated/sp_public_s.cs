// -------------------------------------------------------------------------
//  Managed wrapper for sp_public_s
//  Generated from bindings.xml on 02/28/2012 15:56:54
//
//  This file was auto generated. Do not edit.
// -------------------------------------------------------------------------

using System;
using Mono.Cxxi;

namespace AlliedMods {
	public partial class sp_public_s : ICppObject {

		private static readonly Isp_public_s impl = Libs.AlliedMods.GetClass<Isp_public_s,_sp_public_s,sp_public_s> ("sp_public_s");
		public CppInstancePtr Native { get; protected set; }

		[MangleAs ("struct sp_public_s")]
		public partial interface Isp_public_s : ICppClassOverridable<sp_public_s> {
			CppField<uint> funcid { get; }
			CppField<uint> code_offs { get; }
			CppField<string> name { get; }
		}
		public unsafe struct _sp_public_s {
			public uint funcid;
			public uint code_offs;
			public string name;
		}

		public uint funcid {
			get {
				return impl.funcid [Native];
			}
			set {
				impl.funcid [Native] = value;
			}
		}
		public uint code_offs {
			get {
				return impl.code_offs [Native];
			}
			set {
				impl.code_offs [Native] = value;
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



		public sp_public_s (CppTypeInfo subClass)
		{
			__cxxi_LayoutClass ();
			subClass.AddBase (impl.TypeInfo);
		}

		public sp_public_s (CppInstancePtr native)
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

