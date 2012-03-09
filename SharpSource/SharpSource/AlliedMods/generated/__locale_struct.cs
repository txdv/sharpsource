// -------------------------------------------------------------------------
//  Managed wrapper for __locale_struct
//  Generated from bindings.xml on 02/28/2012 15:56:54
//
//  This file was auto generated. Do not edit.
// -------------------------------------------------------------------------

using System;
using Mono.Cxxi;

namespace AlliedMods {
	public partial class __locale_struct : ICppObject {

		private static readonly I__locale_struct impl = Libs.AlliedMods.GetClass<I__locale_struct,___locale_struct,__locale_struct> ("__locale_struct");
		public CppInstancePtr Native { get; protected set; }

		[MangleAs ("struct __locale_struct")]
		public partial interface I__locale_struct : ICppClassOverridable<__locale_struct> {
			CppField<IntPtr> __locales { get; }
			CppField<IntPtr> __ctype_b { get; }
			CppField<IntPtr> __ctype_tolower { get; }
			CppField<IntPtr> __ctype_toupper { get; }
			CppField<string> __names { get; }
		}
		public unsafe struct ___locale_struct {
			public IntPtr __locales;
			public IntPtr __ctype_b;
			public IntPtr __ctype_tolower;
			public IntPtr __ctype_toupper;
			public fixed int __names [13];
		}

		public IntPtr __locales {
			get {
				return impl.__locales [Native];
			}
			set {
				impl.__locales [Native] = value;
			}
		}
		public ushort __ctype_b {
			get {
				return (ushort) impl.__ctype_b [Native];
			}
			set {
				impl.__ctype_b [Native] = (IntPtr) value;
			}
		}
		public int __ctype_tolower {
			get {
				return (int) impl.__ctype_tolower [Native];
			}
			set {
				impl.__ctype_tolower [Native] = (IntPtr) value;
			}
		}
		public int __ctype_toupper {
			get {
				return (int) impl.__ctype_toupper [Native];
			}
			set {
				impl.__ctype_toupper [Native] = (IntPtr) value;
			}
		}
		public string __names {
			get {
				return impl.__names [Native];
			}
			set {
				impl.__names [Native] = value;
			}
		}



		public __locale_struct (CppTypeInfo subClass)
		{
			__cxxi_LayoutClass ();
			subClass.AddBase (impl.TypeInfo);
		}

		public __locale_struct (CppInstancePtr native)
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

