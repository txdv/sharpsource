// -------------------------------------------------------------------------
//  Managed wrapper for SMInterface
//  Generated from bindings.xml on 02/28/2012 15:56:54
//
//  This file was auto generated. Do not edit.
// -------------------------------------------------------------------------

using System;
using Mono.Cxxi;

namespace AlliedMods.SourceMod {
	public partial class SMInterface : ICppObject {

		private static readonly ISMInterface impl = Libs.AlliedMods.GetClass<ISMInterface,_SMInterface,SMInterface> ("SMInterface");
		public CppInstancePtr Native { get; protected set; }

		[MangleAs ("class SourceMod::SMInterface")]
		public partial interface ISMInterface : ICppClassOverridable<SMInterface> {
			[Virtual] uint GetInterfaceVersion (CppInstancePtr @this);
			[Virtual] string GetInterfaceName (CppInstancePtr @this);
			[Virtual] [Inline] bool IsVersionCompatible (CppInstancePtr @this, uint version);
		}
		public unsafe struct _SMInterface {
		}




		public SMInterface (CppTypeInfo subClass)
		{
			__cxxi_LayoutClass ();
			subClass.AddBase (impl.TypeInfo);
		}

		public SMInterface (CppInstancePtr native)
		{
			__cxxi_LayoutClass ();
			Native = native;
		}

		[OverrideNative ("GetInterfaceVersion")]
		public virtual uint GetInterfaceVersion ()
		{
			return impl.GetInterfaceVersion (Native);
		}
		[OverrideNative ("GetInterfaceName")]
		public virtual string GetInterfaceName ()
		{
			return impl.GetInterfaceName (Native);
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

