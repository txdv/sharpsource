// -------------------------------------------------------------------------
//  Managed wrapper for __mbstate_t
//  Generated from bindings.xml on 02/28/2012 15:56:54
//
//  This file was auto generated. Do not edit.
// -------------------------------------------------------------------------

using System;
using Mono.Cxxi;

namespace AlliedMods {
	public partial class __mbstate_t : ICppObject {

		private static readonly I__mbstate_t impl = Libs.AlliedMods.GetClass<I__mbstate_t,___mbstate_t,__mbstate_t> ("__mbstate_t");
		public CppInstancePtr Native { get; protected set; }

		[MangleAs ("struct __mbstate_t")]
		public partial interface I__mbstate_t : ICppClassOverridable<__mbstate_t> {
			CppField<int> __count { get; }
			CppField<IntPtr> __value { get; }
		}
		public unsafe struct ___mbstate_t {
			public int __count;
			public IntPtr __value;
		}

		public int __count {
			get {
				return impl.__count [Native];
			}
			set {
				impl.__count [Native] = value;
			}
		}
		public IntPtr __value {
			get {
				return impl.__value [Native];
			}
			set {
				impl.__value [Native] = value;
			}
		}



		public __mbstate_t (CppTypeInfo subClass)
		{
			__cxxi_LayoutClass ();
			subClass.AddBase (impl.TypeInfo);
		}

		public __mbstate_t (CppInstancePtr native)
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

