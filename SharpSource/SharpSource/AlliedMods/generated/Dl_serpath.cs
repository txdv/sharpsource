// -------------------------------------------------------------------------
//  Managed wrapper for Dl_serpath
//  Generated from bindings.xml on 02/28/2012 15:56:54
//
//  This file was auto generated. Do not edit.
// -------------------------------------------------------------------------

using System;
using Mono.Cxxi;

namespace AlliedMods {
	public partial class Dl_serpath : ICppObject {

		private static readonly IDl_serpath impl = Libs.AlliedMods.GetClass<IDl_serpath,_Dl_serpath,Dl_serpath> ("Dl_serpath");
		public CppInstancePtr Native { get; protected set; }

		[MangleAs ("struct Dl_serpath")]
		public partial interface IDl_serpath : ICppClassOverridable<Dl_serpath> {
			CppField<string> dls_name { get; }
			CppField<uint> dls_flags { get; }
		}
		public unsafe struct _Dl_serpath {
			public string dls_name;
			public uint dls_flags;
		}

		public string dls_name {
			get {
				return impl.dls_name [Native];
			}
			set {
				impl.dls_name [Native] = value;
			}
		}
		public uint dls_flags {
			get {
				return impl.dls_flags [Native];
			}
			set {
				impl.dls_flags [Native] = value;
			}
		}



		public Dl_serpath (CppTypeInfo subClass)
		{
			__cxxi_LayoutClass ();
			subClass.AddBase (impl.TypeInfo);
		}

		public Dl_serpath (CppInstancePtr native)
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

