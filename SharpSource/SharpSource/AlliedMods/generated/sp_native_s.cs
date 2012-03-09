// -------------------------------------------------------------------------
//  Managed wrapper for sp_native_s
//  Generated from bindings.xml on 02/28/2012 15:56:54
//
//  This file was auto generated. Do not edit.
// -------------------------------------------------------------------------

using System;
using Mono.Cxxi;

namespace AlliedMods {
	public partial class sp_native_s : ICppObject {

		private static readonly Isp_native_s impl = Libs.AlliedMods.GetClass<Isp_native_s,_sp_native_s,sp_native_s> ("sp_native_s");
		public CppInstancePtr Native { get; protected set; }

		[MangleAs ("struct sp_native_s")]
		public partial interface Isp_native_s : ICppClassOverridable<sp_native_s> {
			CppField<IntPtr> pfn { get; }
			CppField<string> name { get; }
			CppField<uint> status { get; }
			CppField<uint> flags { get; }
			CppField<IntPtr> user { get; }
		}
		public unsafe struct _sp_native_s {
			public IntPtr pfn;
			public string name;
			public uint status;
			public uint flags;
			public IntPtr user;
		}

		public IntPtr pfn {
			get {
				return impl.pfn [Native];
			}
			set {
				impl.pfn [Native] = value;
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
		public uint status {
			get {
				return impl.status [Native];
			}
			set {
				impl.status [Native] = value;
			}
		}
		public uint flags {
			get {
				return impl.flags [Native];
			}
			set {
				impl.flags [Native] = value;
			}
		}
		public IntPtr user {
			get {
				return impl.user [Native];
			}
			set {
				impl.user [Native] = value;
			}
		}



		public sp_native_s (CppTypeInfo subClass)
		{
			__cxxi_LayoutClass ();
			subClass.AddBase (impl.TypeInfo);
		}

		public sp_native_s (CppInstancePtr native)
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

