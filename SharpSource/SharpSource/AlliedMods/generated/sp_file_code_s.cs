// -------------------------------------------------------------------------
//  Managed wrapper for sp_file_code_s
//  Generated from bindings.xml on 02/28/2012 15:56:54
//
//  This file was auto generated. Do not edit.
// -------------------------------------------------------------------------

using System;
using Mono.Cxxi;

namespace AlliedMods {
	public partial class sp_file_code_s : ICppObject {

		private static readonly Isp_file_code_s impl = Libs.AlliedMods.GetClass<Isp_file_code_s,_sp_file_code_s,sp_file_code_s> ("sp_file_code_s");
		public CppInstancePtr Native { get; protected set; }

		[MangleAs ("struct sp_file_code_s")]
		public partial interface Isp_file_code_s : ICppClassOverridable<sp_file_code_s> {
			CppField<uint> codesize { get; }
			CppField<char> cellsize { get; }
			CppField<char> codeversion { get; }
			CppField<ushort> flags { get; }
			CppField<uint> main { get; }
			CppField<uint> code { get; }
		}
		public unsafe struct _sp_file_code_s {
			public uint codesize;
			public char cellsize;
			public char codeversion;
			public ushort flags;
			public uint main;
			public uint code;
		}

		public uint codesize {
			get {
				return impl.codesize [Native];
			}
			set {
				impl.codesize [Native] = value;
			}
		}
		public char cellsize {
			get {
				return impl.cellsize [Native];
			}
			set {
				impl.cellsize [Native] = value;
			}
		}
		public char codeversion {
			get {
				return impl.codeversion [Native];
			}
			set {
				impl.codeversion [Native] = value;
			}
		}
		public ushort flags {
			get {
				return impl.flags [Native];
			}
			set {
				impl.flags [Native] = value;
			}
		}
		public uint main {
			get {
				return impl.main [Native];
			}
			set {
				impl.main [Native] = value;
			}
		}
		public uint code {
			get {
				return impl.code [Native];
			}
			set {
				impl.code [Native] = value;
			}
		}



		public sp_file_code_s (CppTypeInfo subClass)
		{
			__cxxi_LayoutClass ();
			subClass.AddBase (impl.TypeInfo);
		}

		public sp_file_code_s (CppInstancePtr native)
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

