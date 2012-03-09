// -------------------------------------------------------------------------
//  Managed wrapper for stat64
//  Generated from bindings.xml on 02/28/2012 15:56:54
//
//  This file was auto generated. Do not edit.
// -------------------------------------------------------------------------

using System;
using Mono.Cxxi;

namespace AlliedMods {
	public partial class stat64 : ICppObject {

		private static readonly Istat64 impl = Libs.AlliedMods.GetClass<Istat64,_stat64,stat64> ("stat64");
		public CppInstancePtr Native { get; protected set; }

		[MangleAs ("struct stat64")]
		public partial interface Istat64 : ICppClassOverridable<stat64> {
			CppField<ulong> st_dev { get; }
			CppField<uint> __pad1 { get; }
			CppField<uint> __st_ino { get; }
			CppField<uint> st_mode { get; }
			CppField<uint> st_nlink { get; }
			CppField<uint> st_uid { get; }
			CppField<uint> st_gid { get; }
			CppField<ulong> st_rdev { get; }
			CppField<uint> __pad2 { get; }
			CppField<long> st_size { get; }
			CppField<int> st_blksize { get; }
			CppField<long> st_blocks { get; }
			CppField<timespec> st_atim { get; }
			CppField<timespec> st_mtim { get; }
			CppField<timespec> st_ctim { get; }
			CppField<ulong> st_ino { get; }
		}
		public unsafe struct _stat64 {
			public ulong st_dev;
			public uint __pad1;
			public uint __st_ino;
			public uint st_mode;
			public uint st_nlink;
			public uint st_uid;
			public uint st_gid;
			public ulong st_rdev;
			public uint __pad2;
			public long st_size;
			public int st_blksize;
			public long st_blocks;
			public timespec._timespec st_atim;
			public timespec._timespec st_mtim;
			public timespec._timespec st_ctim;
			public ulong st_ino;
		}

		public ulong st_dev {
			get {
				return impl.st_dev [Native];
			}
			set {
				impl.st_dev [Native] = value;
			}
		}
		public uint __pad1 {
			get {
				return impl.__pad1 [Native];
			}
			set {
				impl.__pad1 [Native] = value;
			}
		}
		public uint __st_ino {
			get {
				return impl.__st_ino [Native];
			}
			set {
				impl.__st_ino [Native] = value;
			}
		}
		public uint st_mode {
			get {
				return impl.st_mode [Native];
			}
			set {
				impl.st_mode [Native] = value;
			}
		}
		public uint st_nlink {
			get {
				return impl.st_nlink [Native];
			}
			set {
				impl.st_nlink [Native] = value;
			}
		}
		public uint st_uid {
			get {
				return impl.st_uid [Native];
			}
			set {
				impl.st_uid [Native] = value;
			}
		}
		public uint st_gid {
			get {
				return impl.st_gid [Native];
			}
			set {
				impl.st_gid [Native] = value;
			}
		}
		public ulong st_rdev {
			get {
				return impl.st_rdev [Native];
			}
			set {
				impl.st_rdev [Native] = value;
			}
		}
		public uint __pad2 {
			get {
				return impl.__pad2 [Native];
			}
			set {
				impl.__pad2 [Native] = value;
			}
		}
		public long st_size {
			get {
				return impl.st_size [Native];
			}
			set {
				impl.st_size [Native] = value;
			}
		}
		public int st_blksize {
			get {
				return impl.st_blksize [Native];
			}
			set {
				impl.st_blksize [Native] = value;
			}
		}
		public long st_blocks {
			get {
				return impl.st_blocks [Native];
			}
			set {
				impl.st_blocks [Native] = value;
			}
		}
		public timespec st_atim {
			get {
				return impl.st_atim [Native];
			}
			set {
				impl.st_atim [Native] = value;
			}
		}
		public timespec st_mtim {
			get {
				return impl.st_mtim [Native];
			}
			set {
				impl.st_mtim [Native] = value;
			}
		}
		public timespec st_ctim {
			get {
				return impl.st_ctim [Native];
			}
			set {
				impl.st_ctim [Native] = value;
			}
		}
		public ulong st_ino {
			get {
				return impl.st_ino [Native];
			}
			set {
				impl.st_ino [Native] = value;
			}
		}



		public stat64 (CppTypeInfo subClass)
		{
			__cxxi_LayoutClass ();
			subClass.AddBase (impl.TypeInfo);
		}

		public stat64 (CppInstancePtr native)
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

