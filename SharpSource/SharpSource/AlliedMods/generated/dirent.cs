// -------------------------------------------------------------------------
//  Managed wrapper for dirent
//  Generated from bindings.xml on 02/28/2012 15:56:54
//
//  This file was auto generated. Do not edit.
// -------------------------------------------------------------------------

using System;
using Mono.Cxxi;

namespace AlliedMods {
	public partial class dirent : ICppObject {

		private static readonly Idirent impl = Libs.AlliedMods.GetClass<Idirent,_dirent,dirent> ("dirent");
		public CppInstancePtr Native { get; protected set; }

		[MangleAs ("struct dirent")]
		public partial interface Idirent : ICppClassOverridable<dirent> {
			CppField<uint> d_ino { get; }
			CppField<int> d_off { get; }
			CppField<ushort> d_reclen { get; }
			CppField<char> d_type { get; }
			CppField<Char[]> d_name { get; }
		}
		public unsafe struct _dirent {
			public uint d_ino;
			public int d_off;
			public ushort d_reclen;
			public char d_type;
			public fixed Char d_name [256];
		}

		public uint d_ino {
			get {
				return impl.d_ino [Native];
			}
			set {
				impl.d_ino [Native] = value;
			}
		}
		public int d_off {
			get {
				return impl.d_off [Native];
			}
			set {
				impl.d_off [Native] = value;
			}
		}
		public ushort d_reclen {
			get {
				return impl.d_reclen [Native];
			}
			set {
				impl.d_reclen [Native] = value;
			}
		}
		public char d_type {
			get {
				return impl.d_type [Native];
			}
			set {
				impl.d_type [Native] = value;
			}
		}
		public Char[] d_name {
			get {
				return impl.d_name [Native];
			}
			set {
				impl.d_name [Native] = value;
			}
		}



		public dirent (CppTypeInfo subClass)
		{
			__cxxi_LayoutClass ();
			subClass.AddBase (impl.TypeInfo);
		}

		public dirent (CppInstancePtr native)
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

