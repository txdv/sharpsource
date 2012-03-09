// -------------------------------------------------------------------------
//  Managed wrapper for sp_pubvar_s
//  Generated from bindings.xml on 02/28/2012 15:56:54
//
//  This file was auto generated. Do not edit.
// -------------------------------------------------------------------------

using System;
using Mono.Cxxi;

namespace AlliedMods {
	public partial class sp_pubvar_s : ICppObject {

		private static readonly Isp_pubvar_s impl = Libs.AlliedMods.GetClass<Isp_pubvar_s,_sp_pubvar_s,sp_pubvar_s> ("sp_pubvar_s");
		public CppInstancePtr Native { get; protected set; }

		[MangleAs ("struct sp_pubvar_s")]
		public partial interface Isp_pubvar_s : ICppClassOverridable<sp_pubvar_s> {
			CppField<IntPtr> offs { get; }
			CppField<string> name { get; }
		}
		public unsafe struct _sp_pubvar_s {
			public IntPtr offs;
			public string name;
		}

		public int offs {
			get {
				return (int) impl.offs [Native];
			}
			set {
				impl.offs [Native] = (IntPtr) value;
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



		public sp_pubvar_s (CppTypeInfo subClass)
		{
			__cxxi_LayoutClass ();
			subClass.AddBase (impl.TypeInfo);
		}

		public sp_pubvar_s (CppInstancePtr native)
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

