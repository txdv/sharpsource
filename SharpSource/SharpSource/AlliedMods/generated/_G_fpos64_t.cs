// -------------------------------------------------------------------------
//  Managed wrapper for _G_fpos64_t
//  Generated from bindings.xml on 02/28/2012 15:56:54
//
//  This file was auto generated. Do not edit.
// -------------------------------------------------------------------------

using System;
using Mono.Cxxi;

namespace AlliedMods {
	public partial class _G_fpos64_t : ICppObject {

		private static readonly I_G_fpos64_t impl = Libs.AlliedMods.GetClass<I_G_fpos64_t,__G_fpos64_t,_G_fpos64_t> ("_G_fpos64_t");
		public CppInstancePtr Native { get; protected set; }

		[MangleAs ("struct _G_fpos64_t")]
		public partial interface I_G_fpos64_t : ICppClassOverridable<_G_fpos64_t> {
			CppField<long> __pos { get; }
			CppField<__mbstate_t> __state { get; }
		}
		public unsafe struct __G_fpos64_t {
			public long __pos;
			public __mbstate_t.___mbstate_t __state;
		}

		public long __pos {
			get {
				return impl.__pos [Native];
			}
			set {
				impl.__pos [Native] = value;
			}
		}
		public __mbstate_t __state {
			get {
				return impl.__state [Native];
			}
			set {
				impl.__state [Native] = value;
			}
		}



		public _G_fpos64_t (CppTypeInfo subClass)
		{
			__cxxi_LayoutClass ();
			subClass.AddBase (impl.TypeInfo);
		}

		public _G_fpos64_t (CppInstancePtr native)
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

