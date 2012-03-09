// -------------------------------------------------------------------------
//  Managed wrapper for HandleSecurity
//  Generated from bindings.xml on 02/28/2012 15:56:54
//
//  This file was auto generated. Do not edit.
// -------------------------------------------------------------------------

using System;
using Mono.Cxxi;

namespace AlliedMods.SourceMod {
	public partial class HandleSecurity : ICppObject {

		private static readonly IHandleSecurity impl = Libs.AlliedMods.GetClass<IHandleSecurity,_HandleSecurity,HandleSecurity> ("HandleSecurity");
		public CppInstancePtr Native { get; protected set; }

		[MangleAs ("struct SourceMod::HandleSecurity")]
		public partial interface IHandleSecurity : ICppClassOverridable<HandleSecurity> {
			CppField<IntPtr> pOwner { get; }
			CppField<IntPtr> pIdentity { get; }
		}
		public unsafe struct _HandleSecurity {
			public IntPtr pOwner;
			public IntPtr pIdentity;
		}

		public IntPtr pOwner {
			get {
				return impl.pOwner [Native];
			}
			set {
				impl.pOwner [Native] = value;
			}
		}
		public IntPtr pIdentity {
			get {
				return impl.pIdentity [Native];
			}
			set {
				impl.pIdentity [Native] = value;
			}
		}



		public HandleSecurity (CppTypeInfo subClass)
		{
			__cxxi_LayoutClass ();
			subClass.AddBase (impl.TypeInfo);
		}

		public HandleSecurity (CppInstancePtr native)
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

