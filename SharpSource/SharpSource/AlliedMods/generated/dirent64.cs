// -------------------------------------------------------------------------
//  Managed wrapper for dirent64
//  Generated from bindings.xml on 02/28/2012 15:56:54
//
//  This file was auto generated. Do not edit.
// -------------------------------------------------------------------------

using System;
using Mono.Cxxi;

namespace AlliedMods {
	public partial class dirent64 : ICppObject {

		private static readonly Idirent64 impl = Libs.AlliedMods.GetClass<Idirent64,_dirent64,dirent64> ("dirent64");
		public CppInstancePtr Native { get; protected set; }

		[MangleAs ("struct dirent64")]
		public partial interface Idirent64 : ICppClassOverridable<dirent64> {
			CppField<ulong> d_ino { get; }
			CppField<long> d_off { get; }
			CppField<ushort> d_reclen { get; }
			CppField<char> d_type { get; }
			CppField<Char[]> d_name { get; }
		}
		public unsafe struct _dirent64 {
			public ulong d_ino;
			public long d_off;
			public ushort d_reclen;
			public char d_type;
			public fixed Char d_name [256];
		}

		public ulong d_ino {
			get {
				return impl.d_ino [Native];
			}
			set {
				impl.d_ino [Native] = value;
			}
		}
		public long d_off {
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



		public dirent64 (CppTypeInfo subClass)
		{
			__cxxi_LayoutClass ();
			subClass.AddBase (impl.TypeInfo);
		}

		public dirent64 (CppInstancePtr native)
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

