// -------------------------------------------------------------------------
//  Managed wrapper for ILibrary
//  Generated from bindings.xml on 02/28/2012 15:56:54
//
//  This file was auto generated. Do not edit.
// -------------------------------------------------------------------------

using System;
using Mono.Cxxi;

namespace AlliedMods.SourceMod {
	public partial class ILibrary : ICppObject {

		private static readonly IILibrary impl = Libs.AlliedMods.GetClass<IILibrary,_ILibrary,ILibrary> ("ILibrary");
		public CppInstancePtr Native { get; protected set; }

		[MangleAs ("class SourceMod::ILibrary")]
		public partial interface IILibrary : ICppClassOverridable<ILibrary> {
			[Virtual] [Inline] [Destructor] void Destruct (CppInstancePtr @this);
			[Virtual] void CloseLibrary (CppInstancePtr @this);
			[Virtual] IntPtr GetSymbolAddress (CppInstancePtr @this, string symname);
		}
		public unsafe struct _ILibrary {
		}




		public ILibrary (CppTypeInfo subClass)
		{
			__cxxi_LayoutClass ();
			subClass.AddBase (impl.TypeInfo);
		}

		public ILibrary (CppInstancePtr native)
		{
			__cxxi_LayoutClass ();
			Native = native;
		}

		[OverrideNative ("CloseLibrary")]
		public virtual void CloseLibrary ()
		{
			impl.CloseLibrary (Native);
		}
		[OverrideNative ("GetSymbolAddress")]
		public virtual IntPtr GetSymbolAddress (string symname)
		{
			return impl.GetSymbolAddress (Native, symname);
		}


		partial void BeforeDestruct ();
		partial void AfterDestruct ();

		public virtual void Dispose ()
		{
			BeforeDestruct ();
			impl.Destruct (Native);
			Native.Dispose ();
			AfterDestruct ();
		}

		private void __cxxi_LayoutClass ()
		{
			impl.TypeInfo.CompleteType ();
		}

	}
}

