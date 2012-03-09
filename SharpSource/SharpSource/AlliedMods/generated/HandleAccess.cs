// -------------------------------------------------------------------------
//  Managed wrapper for HandleAccess
//  Generated from bindings.xml on 02/28/2012 15:56:54
//
//  This file was auto generated. Do not edit.
// -------------------------------------------------------------------------

using System;
using Mono.Cxxi;

namespace AlliedMods.SourceMod {
	public partial class HandleAccess : ICppObject {

		private static readonly IHandleAccess impl = Libs.AlliedMods.GetClass<IHandleAccess,_HandleAccess,HandleAccess> ("HandleAccess");
		public CppInstancePtr Native { get; protected set; }

		[MangleAs ("struct SourceMod::HandleAccess")]
		public partial interface IHandleAccess : ICppClassOverridable<HandleAccess> {
			CppField<uint> hsVersion { get; }
			CppField<UInt32[]> access { get; }
		}
		public unsafe struct _HandleAccess {
			public uint hsVersion;
			public fixed UInt32 access [3];
		}

		public uint hsVersion {
			get {
				return impl.hsVersion [Native];
			}
			set {
				impl.hsVersion [Native] = value;
			}
		}
		public UInt32[] access {
			get {
				return impl.access [Native];
			}
			set {
				impl.access [Native] = value;
			}
		}



		public HandleAccess (CppTypeInfo subClass)
		{
			__cxxi_LayoutClass ();
			subClass.AddBase (impl.TypeInfo);
		}

		public HandleAccess (CppInstancePtr native)
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

