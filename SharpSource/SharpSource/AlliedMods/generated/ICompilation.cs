// -------------------------------------------------------------------------
//  Managed wrapper for ICompilation
//  Generated from bindings.xml on 02/28/2012 15:56:54
//
//  This file was auto generated. Do not edit.
// -------------------------------------------------------------------------

using System;
using Mono.Cxxi;

namespace AlliedMods.SourcePawn {
	public partial class ICompilation : ICppObject {

		private static readonly IICompilation impl = Libs.AlliedMods.GetClass<IICompilation,_ICompilation,ICompilation> ("ICompilation");
		public CppInstancePtr Native { get; protected set; }

		[MangleAs ("class SourcePawn::ICompilation")]
		public partial interface IICompilation : ICppClassOverridable<ICompilation> {
			[Virtual] bool SetOption (CppInstancePtr @this, string key, string val);
			[Virtual] void Abort (CppInstancePtr @this);
		}
		public unsafe struct _ICompilation {
		}




		public ICompilation (CppTypeInfo subClass)
		{
			__cxxi_LayoutClass ();
			subClass.AddBase (impl.TypeInfo);
		}

		public ICompilation (CppInstancePtr native)
		{
			__cxxi_LayoutClass ();
			Native = native;
		}

		[OverrideNative ("SetOption")]
		public virtual bool SetOption (string key, string val)
		{
			return impl.SetOption (Native, key, val);
		}
		[OverrideNative ("Abort")]
		public virtual void Abort ()
		{
			impl.Abort (Native);
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

