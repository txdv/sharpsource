// -------------------------------------------------------------------------
//  Managed wrapper for _IO_cookie_io_functions_t
//  Generated from bindings.xml on 02/28/2012 15:56:54
//
//  This file was auto generated. Do not edit.
// -------------------------------------------------------------------------

using System;
using Mono.Cxxi;

namespace AlliedMods {
	public partial class _IO_cookie_io_functions_t : ICppObject {

		private static readonly I_IO_cookie_io_functions_t impl = Libs.AlliedMods.GetClass<I_IO_cookie_io_functions_t,__IO_cookie_io_functions_t,_IO_cookie_io_functions_t> ("_IO_cookie_io_functions_t");
		public CppInstancePtr Native { get; protected set; }

		[MangleAs ("struct _IO_cookie_io_functions_t")]
		public partial interface I_IO_cookie_io_functions_t : ICppClassOverridable<_IO_cookie_io_functions_t> {
			CppField<IntPtr> read { get; }
			CppField<IntPtr> write { get; }
			CppField<IntPtr> seek { get; }
			CppField<IntPtr> close { get; }
		}
		public unsafe struct __IO_cookie_io_functions_t {
			public IntPtr read;
			public IntPtr write;
			public IntPtr seek;
			public IntPtr close;
		}

		public IntPtr read {
			get {
				return impl.read [Native];
			}
			set {
				impl.read [Native] = value;
			}
		}
		public IntPtr write {
			get {
				return impl.write [Native];
			}
			set {
				impl.write [Native] = value;
			}
		}
		public IntPtr seek {
			get {
				return impl.seek [Native];
			}
			set {
				impl.seek [Native] = value;
			}
		}
		public IntPtr close {
			get {
				return impl.close [Native];
			}
			set {
				impl.close [Native] = value;
			}
		}



		public _IO_cookie_io_functions_t (CppTypeInfo subClass)
		{
			__cxxi_LayoutClass ();
			subClass.AddBase (impl.TypeInfo);
		}

		public _IO_cookie_io_functions_t (CppInstancePtr native)
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

