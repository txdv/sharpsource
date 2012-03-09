// -------------------------------------------------------------------------
//  Managed wrapper for stat
//  Generated from bindings.xml on 02/28/2012 15:56:54
//
//  This file was auto generated. Do not edit.
// -------------------------------------------------------------------------

using System;
using Mono.Cxxi;

namespace AlliedMods {
	public partial class stat : ICppObject {

		private static readonly Istat impl = Libs.AlliedMods.GetClass<Istat,_stat,stat> ("stat");
		public CppInstancePtr Native { get; protected set; }

		[MangleAs ("struct stat")]
		public partial interface Istat : ICppClassOverridable<stat> {
			CppField<ulong> st_dev { get; }
			CppField<ushort> __pad1 { get; }
			CppField<uint> st_ino { get; }
			CppField<uint> st_mode { get; }
			CppField<uint> st_nlink { get; }
			CppField<uint> st_uid { get; }
			CppField<uint> st_gid { get; }
			CppField<ulong> st_rdev { get; }
			CppField<ushort> __pad2 { get; }
			CppField<int> st_size { get; }
			CppField<int> st_blksize { get; }
			CppField<int> st_blocks { get; }
			CppField<timespec> st_atim { get; }
			CppField<timespec> st_mtim { get; }
			CppField<timespec> st_ctim { get; }
			CppField<uint> __unused4 { get; }
			CppField<uint> __unused5 { get; }
		}
		public unsafe struct _stat {
			public ulong st_dev;
			public ushort __pad1;
			public uint st_ino;
			public uint st_mode;
			public uint st_nlink;
			public uint st_uid;
			public uint st_gid;
			public ulong st_rdev;
			public ushort __pad2;
			public int st_size;
			public int st_blksize;
			public int st_blocks;
			public timespec._timespec st_atim;
			public timespec._timespec st_mtim;
			public timespec._timespec st_ctim;
			public uint __unused4;
			public uint __unused5;
		}

		public ulong st_dev {
			get {
				return impl.st_dev [Native];
			}
			set {
				impl.st_dev [Native] = value;
			}
		}
		public ushort __pad1 {
			get {
				return impl.__pad1 [Native];
			}
			set {
				impl.__pad1 [Native] = value;
			}
		}
		public uint st_ino {
			get {
				return impl.st_ino [Native];
			}
			set {
				impl.st_ino [Native] = value;
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
		public ushort __pad2 {
			get {
				return impl.__pad2 [Native];
			}
			set {
				impl.__pad2 [Native] = value;
			}
		}
		public int st_size {
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
		public int st_blocks {
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
		public uint __unused4 {
			get {
				return impl.__unused4 [Native];
			}
			set {
				impl.__unused4 [Native] = value;
			}
		}
		public uint __unused5 {
			get {
				return impl.__unused5 [Native];
			}
			set {
				impl.__unused5 [Native] = value;
			}
		}



		public stat (CppTypeInfo subClass)
		{
			__cxxi_LayoutClass ();
			subClass.AddBase (impl.TypeInfo);
		}

		public stat (CppInstancePtr native)
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

