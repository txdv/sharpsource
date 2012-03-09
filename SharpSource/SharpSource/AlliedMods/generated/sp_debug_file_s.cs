// -------------------------------------------------------------------------
//  Managed wrapper for sp_debug_file_s
//  Generated from bindings.xml on 02/28/2012 15:56:54
//
//  This file was auto generated. Do not edit.
// -------------------------------------------------------------------------

using System;
using Mono.Cxxi;

namespace AlliedMods {
	public partial class sp_debug_file_s : ICppObject {

		private static readonly Isp_debug_file_s impl = Libs.AlliedMods.GetClass<Isp_debug_file_s,_sp_debug_file_s,sp_debug_file_s> ("sp_debug_file_s");
		public CppInstancePtr Native { get; protected set; }

		[MangleAs ("struct sp_debug_file_s")]
		public partial interface Isp_debug_file_s : ICppClassOverridable<sp_debug_file_s> {
			CppField<uint> addr { get; }
			CppField<string> name { get; }
		}
		public unsafe struct _sp_debug_file_s {
			public uint addr;
			public string name;
		}

		public uint addr {
			get {
				return impl.addr [Native];
			}
			set {
				impl.addr [Native] = value;
			}
		}
		public string name {
			get {
				return impl.name [Native];
			}
			set {
				impl.name [Native] = value;
			}
		}



		public sp_debug_file_s (CppTypeInfo subClass)
		{
			__cxxi_LayoutClass ();
			subClass.AddBase (impl.TypeInfo);
		}

		public sp_debug_file_s (CppInstancePtr native)
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

