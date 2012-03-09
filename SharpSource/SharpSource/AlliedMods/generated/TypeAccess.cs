// -------------------------------------------------------------------------
//  Managed wrapper for TypeAccess
//  Generated from bindings.xml on 02/28/2012 15:56:54
//
//  This file was auto generated. Do not edit.
// -------------------------------------------------------------------------

using System;
using Mono.Cxxi;

namespace AlliedMods.SourceMod {
	public partial class TypeAccess : ICppObject {

		private static readonly ITypeAccess impl = Libs.AlliedMods.GetClass<ITypeAccess,_TypeAccess,TypeAccess> ("TypeAccess");
		public CppInstancePtr Native { get; protected set; }

		[MangleAs ("struct SourceMod::TypeAccess")]
		public partial interface ITypeAccess : ICppClassOverridable<TypeAccess> {
			CppField<uint> hsVersion { get; }
			CppField<IntPtr> ident { get; }
			CppField<Boolean[]> access { get; }
		}
		public unsafe struct _TypeAccess {
			public uint hsVersion;
			public IntPtr ident;
			public fixed Boolean access [2];
		}

		public uint hsVersion {
			get {
				return impl.hsVersion [Native];
			}
			set {
				impl.hsVersion [Native] = value;
			}
		}
		public IntPtr ident {
			get {
				return impl.ident [Native];
			}
			set {
				impl.ident [Native] = value;
			}
		}
		public Boolean[] access {
			get {
				return impl.access [Native];
			}
			set {
				impl.access [Native] = value;
			}
		}



		public TypeAccess (CppTypeInfo subClass)
		{
			__cxxi_LayoutClass ();
			subClass.AddBase (impl.TypeInfo);
		}

		public TypeAccess (CppInstancePtr native)
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

