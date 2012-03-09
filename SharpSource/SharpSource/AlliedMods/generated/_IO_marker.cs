// -------------------------------------------------------------------------
//  Managed wrapper for _IO_marker
//  Generated from bindings.xml on 02/28/2012 15:56:54
//
//  This file was auto generated. Do not edit.
// -------------------------------------------------------------------------

using System;
using Mono.Cxxi;

namespace AlliedMods {
	public partial class _IO_marker : ICppObject {

		private static readonly I_IO_marker impl = Libs.AlliedMods.GetClass<I_IO_marker,__IO_marker,_IO_marker> ("_IO_marker");
		public CppInstancePtr Native { get; protected set; }

		[MangleAs ("struct _IO_marker")]
		public partial interface I_IO_marker : ICppClassOverridable<_IO_marker> {
			CppField<_IO_marker> _next { get; }
			CppField<_IO_FILE> _sbuf { get; }
			CppField<int> _pos { get; }
		}
		public unsafe struct __IO_marker {
			public _IO_marker _next;
			public _IO_FILE _sbuf;
			public int _pos;
		}

		public _IO_marker _next {
			get {
				return impl._next [Native];
			}
			set {
				impl._next [Native] = value;
			}
		}
		public _IO_FILE _sbuf {
			get {
				return impl._sbuf [Native];
			}
			set {
				impl._sbuf [Native] = value;
			}
		}
		public int _pos {
			get {
				return impl._pos [Native];
			}
			set {
				impl._pos [Native] = value;
			}
		}



		public _IO_marker (CppTypeInfo subClass)
		{
			__cxxi_LayoutClass ();
			subClass.AddBase (impl.TypeInfo);
		}

		public _IO_marker (CppInstancePtr native)
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

