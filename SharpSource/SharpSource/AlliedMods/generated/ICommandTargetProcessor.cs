// -------------------------------------------------------------------------
//  Managed wrapper for ICommandTargetProcessor
//  Generated from bindings.xml on 03/09/2012 13:42:17
//
//  This file was auto generated. Do not edit.
// -------------------------------------------------------------------------

using System;
using Mono.Cxxi;

namespace AlliedMods.SourceMod {
	public partial class ICommandTargetProcessor : ICppObject {

		private static readonly IICommandTargetProcessor impl = Libs.AlliedMods.GetClass<IICommandTargetProcessor,_ICommandTargetProcessor,ICommandTargetProcessor> ("ICommandTargetProcessor");
		public CppInstancePtr Native { get; protected set; }

		[MangleAs ("class SourceMod::ICommandTargetProcessor")]
		public partial interface IICommandTargetProcessor : ICppClassOverridable<ICommandTargetProcessor> {
			[Virtual] bool ProcessCommandTarget (CppInstancePtr @this, SourceMod.cmd_target_info_t info);
		}
		public unsafe struct _ICommandTargetProcessor {
		}




		public ICommandTargetProcessor (CppTypeInfo subClass)
		{
			__cxxi_LayoutClass ();
			subClass.AddBase (impl.TypeInfo);
		}

		public ICommandTargetProcessor (CppInstancePtr native)
		{
			__cxxi_LayoutClass ();
			Native = native;
		}

		[OverrideNative ("ProcessCommandTarget")]
		public virtual bool ProcessCommandTarget (SourceMod.cmd_target_info_t info)
		{
			return impl.ProcessCommandTarget (Native, info);
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

