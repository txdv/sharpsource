// -------------------------------------------------------------------------
//  Managed wrapper for __class_type_info_pseudo
//  Generated from bindings.xml on 02/28/2012 15:56:54
//
//  This file was auto generated. Do not edit.
// -------------------------------------------------------------------------

using System;
using Mono.Cxxi;

namespace AlliedMods {
	public partial class __class_type_info_pseudo : ICppObject {

		private static readonly I__class_type_info_pseudo impl = Libs.AlliedMods.GetClass<I__class_type_info_pseudo,___class_type_info_pseudo,__class_type_info_pseudo> ("__class_type_info_pseudo");
		public CppInstancePtr Native { get; protected set; }

		[MangleAs ("")]
		public partial interface I__class_type_info_pseudo : ICppClassOverridable<__class_type_info_pseudo> {
		}
		public unsafe struct ___class_type_info_pseudo {
		}




		public __class_type_info_pseudo (CppTypeInfo subClass)
		{
			__cxxi_LayoutClass ();
			subClass.AddBase (impl.TypeInfo);
		}

		public __class_type_info_pseudo (CppInstancePtr native)
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

