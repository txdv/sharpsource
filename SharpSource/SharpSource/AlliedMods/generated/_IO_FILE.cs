// -------------------------------------------------------------------------
//  Managed wrapper for _IO_FILE
//  Generated from bindings.xml on 02/28/2012 15:56:54
//
//  This file was auto generated. Do not edit.
// -------------------------------------------------------------------------

using System;
using Mono.Cxxi;

namespace AlliedMods {
	public partial class _IO_FILE : ICppObject {

		private static readonly I_IO_FILE impl = Libs.AlliedMods.GetClass<I_IO_FILE,__IO_FILE,_IO_FILE> ("_IO_FILE");
		public CppInstancePtr Native { get; protected set; }

		[MangleAs ("struct _IO_FILE")]
		public partial interface I_IO_FILE : ICppClassOverridable<_IO_FILE> {
			CppField<int> _flags { get; }
			CppField<string> _IO_read_ptr { get; }
			CppField<string> _IO_read_end { get; }
			CppField<string> _IO_read_base { get; }
			CppField<string> _IO_write_base { get; }
			CppField<string> _IO_write_ptr { get; }
			CppField<string> _IO_write_end { get; }
			CppField<string> _IO_buf_base { get; }
			CppField<string> _IO_buf_end { get; }
			CppField<string> _IO_save_base { get; }
			CppField<string> _IO_backup_base { get; }
			CppField<string> _IO_save_end { get; }
			CppField<_IO_marker> _markers { get; }
			CppField<_IO_FILE> _chain { get; }
			CppField<int> _fileno { get; }
			CppField<int> _flags2 { get; }
			CppField<int> _old_offset { get; }
			CppField<ushort> _cur_column { get; }
			CppField<char> _vtable_offset { get; }
			CppField<Char[]> _shortbuf { get; }
			CppField<IntPtr> _lock { get; }
			CppField<long> _offset { get; }
			CppField<IntPtr> __pad1 { get; }
			CppField<IntPtr> __pad2 { get; }
			CppField<IntPtr> __pad3 { get; }
			CppField<IntPtr> __pad4 { get; }
			CppField<uint> __pad5 { get; }
			CppField<int> _mode { get; }
			CppField<Char[]> _unused2 { get; }
		}
		public unsafe struct __IO_FILE {
			public int _flags;
			public string _IO_read_ptr;
			public string _IO_read_end;
			public string _IO_read_base;
			public string _IO_write_base;
			public string _IO_write_ptr;
			public string _IO_write_end;
			public string _IO_buf_base;
			public string _IO_buf_end;
			public string _IO_save_base;
			public string _IO_backup_base;
			public string _IO_save_end;
			public _IO_marker _markers;
			public _IO_FILE _chain;
			public int _fileno;
			public int _flags2;
			public int _old_offset;
			public ushort _cur_column;
			public char _vtable_offset;
			public fixed Char _shortbuf [1];
			public IntPtr _lock;
			public long _offset;
			public IntPtr __pad1;
			public IntPtr __pad2;
			public IntPtr __pad3;
			public IntPtr __pad4;
			public uint __pad5;
			public int _mode;
			public fixed Char _unused2 [40];
		}

		public int _flags {
			get {
				return impl._flags [Native];
			}
			set {
				impl._flags [Native] = value;
			}
		}
		public string _IO_read_ptr {
			get {
				return impl._IO_read_ptr [Native];
			}
			set {
				impl._IO_read_ptr [Native] = value;
			}
		}
		public string _IO_read_end {
			get {
				return impl._IO_read_end [Native];
			}
			set {
				impl._IO_read_end [Native] = value;
			}
		}
		public string _IO_read_base {
			get {
				return impl._IO_read_base [Native];
			}
			set {
				impl._IO_read_base [Native] = value;
			}
		}
		public string _IO_write_base {
			get {
				return impl._IO_write_base [Native];
			}
			set {
				impl._IO_write_base [Native] = value;
			}
		}
		public string _IO_write_ptr {
			get {
				return impl._IO_write_ptr [Native];
			}
			set {
				impl._IO_write_ptr [Native] = value;
			}
		}
		public string _IO_write_end {
			get {
				return impl._IO_write_end [Native];
			}
			set {
				impl._IO_write_end [Native] = value;
			}
		}
		public string _IO_buf_base {
			get {
				return impl._IO_buf_base [Native];
			}
			set {
				impl._IO_buf_base [Native] = value;
			}
		}
		public string _IO_buf_end {
			get {
				return impl._IO_buf_end [Native];
			}
			set {
				impl._IO_buf_end [Native] = value;
			}
		}
		public string _IO_save_base {
			get {
				return impl._IO_save_base [Native];
			}
			set {
				impl._IO_save_base [Native] = value;
			}
		}
		public string _IO_backup_base {
			get {
				return impl._IO_backup_base [Native];
			}
			set {
				impl._IO_backup_base [Native] = value;
			}
		}
		public string _IO_save_end {
			get {
				return impl._IO_save_end [Native];
			}
			set {
				impl._IO_save_end [Native] = value;
			}
		}
		public _IO_marker _markers {
			get {
				return impl._markers [Native];
			}
			set {
				impl._markers [Native] = value;
			}
		}
		public _IO_FILE _chain {
			get {
				return impl._chain [Native];
			}
			set {
				impl._chain [Native] = value;
			}
		}
		public int _fileno {
			get {
				return impl._fileno [Native];
			}
			set {
				impl._fileno [Native] = value;
			}
		}
		public int _flags2 {
			get {
				return impl._flags2 [Native];
			}
			set {
				impl._flags2 [Native] = value;
			}
		}
		public int _old_offset {
			get {
				return impl._old_offset [Native];
			}
			set {
				impl._old_offset [Native] = value;
			}
		}
		public ushort _cur_column {
			get {
				return impl._cur_column [Native];
			}
			set {
				impl._cur_column [Native] = value;
			}
		}
		public char _vtable_offset {
			get {
				return impl._vtable_offset [Native];
			}
			set {
				impl._vtable_offset [Native] = value;
			}
		}
		public Char[] _shortbuf {
			get {
				return impl._shortbuf [Native];
			}
			set {
				impl._shortbuf [Native] = value;
			}
		}
		public IntPtr _lock {
			get {
				return impl._lock [Native];
			}
			set {
				impl._lock [Native] = value;
			}
		}
		public long _offset {
			get {
				return impl._offset [Native];
			}
			set {
				impl._offset [Native] = value;
			}
		}
		public IntPtr __pad1 {
			get {
				return impl.__pad1 [Native];
			}
			set {
				impl.__pad1 [Native] = value;
			}
		}
		public IntPtr __pad2 {
			get {
				return impl.__pad2 [Native];
			}
			set {
				impl.__pad2 [Native] = value;
			}
		}
		public IntPtr __pad3 {
			get {
				return impl.__pad3 [Native];
			}
			set {
				impl.__pad3 [Native] = value;
			}
		}
		public IntPtr __pad4 {
			get {
				return impl.__pad4 [Native];
			}
			set {
				impl.__pad4 [Native] = value;
			}
		}
		public uint __pad5 {
			get {
				return impl.__pad5 [Native];
			}
			set {
				impl.__pad5 [Native] = value;
			}
		}
		public int _mode {
			get {
				return impl._mode [Native];
			}
			set {
				impl._mode [Native] = value;
			}
		}
		public Char[] _unused2 {
			get {
				return impl._unused2 [Native];
			}
			set {
				impl._unused2 [Native] = value;
			}
		}



		public _IO_FILE (CppTypeInfo subClass)
		{
			__cxxi_LayoutClass ();
			subClass.AddBase (impl.TypeInfo);
		}

		public _IO_FILE (CppInstancePtr native)
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

