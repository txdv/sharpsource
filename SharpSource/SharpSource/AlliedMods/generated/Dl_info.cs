// -------------------------------------------------------------------------
//  Managed wrapper for Dl_info
//  Generated from bindings.xml on 02/28/2012 15:56:54
//
//  This file was auto generated. Do not edit.
// -------------------------------------------------------------------------

using System;
using Mono.Cxxi;

namespace AlliedMods {
	public partial class Dl_info : ICppObject {

		private static readonly IDl_info impl = Libs.AlliedMods.GetClass<IDl_info,_Dl_info,Dl_info> ("Dl_info");
		public CppInstancePtr Native { get; protected set; }

		[MangleAs ("struct Dl_info")]
		public partial interface IDl_info : ICppClassOverridable<Dl_info> {
			CppField<string> dli_fname { get; }
			CppField<IntPtr> dli_fbase { get; }
			CppField<string> dli_sname { get; }
			CppField<IntPtr> dli_saddr { get; }
		}
		public unsafe struct _Dl_info {
			public string dli_fname;
			public IntPtr dli_fbase;
			public string dli_sname;
			public IntPtr dli_saddr;
		}

		public string dli_fname {
			get {
				return impl.dli_fname [Native];
			}
			set {
				impl.dli_fname [Native] = value;
			}
		}
		public IntPtr dli_fbase {
			get {
				return impl.dli_fbase [Native];
			}
			set {
				impl.dli_fbase [Native] = value;
			}
		}
		public string dli_sname {
			get {
				return impl.dli_sname [Native];
			}
			set {
				impl.dli_sname [Native] = value;
			}
		}
		public IntPtr dli_saddr {
			get {
				return impl.dli_saddr [Native];
			}
			set {
				impl.dli_saddr [Native] = value;
			}
		}



		public Dl_info (CppTypeInfo subClass)
		{
			__cxxi_LayoutClass ();
			subClass.AddBase (impl.TypeInfo);
		}

		public Dl_info (CppInstancePtr native)
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

