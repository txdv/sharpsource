// -------------------------------------------------------------------------
//  Managed wrapper for __fsid_t
//  Generated from bindings.xml on 02/28/2012 15:56:54
//
//  This file was auto generated. Do not edit.
// -------------------------------------------------------------------------

using System;
using Mono.Cxxi;

namespace AlliedMods {
	public partial class __fsid_t : ICppObject {

		private static readonly I__fsid_t impl = Libs.AlliedMods.GetClass<I__fsid_t,___fsid_t,__fsid_t> ("__fsid_t");
		public CppInstancePtr Native { get; protected set; }

		[MangleAs ("struct __fsid_t")]
		public partial interface I__fsid_t : ICppClassOverridable<__fsid_t> {
			CppField<Int32[]> __val { get; }
		}
		public unsafe struct ___fsid_t {
			public fixed Int32 __val [2];
		}

		public Int32[] __val {
			get {
				return impl.__val [Native];
			}
			set {
				impl.__val [Native] = value;
			}
		}



		public __fsid_t (CppTypeInfo subClass)
		{
			__cxxi_LayoutClass ();
			subClass.AddBase (impl.TypeInfo);
		}

		public __fsid_t (CppInstancePtr native)
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

