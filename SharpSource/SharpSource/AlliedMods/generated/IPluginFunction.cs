// -------------------------------------------------------------------------
//  Managed wrapper for IPluginFunction
//  Generated from bindings.xml on 02/28/2012 15:56:54
//
//  This file was auto generated. Do not edit.
// -------------------------------------------------------------------------

using System;
using Mono.Cxxi;

namespace AlliedMods.SourcePawn {
	public partial class IPluginFunction : ICallable {

		private static readonly IIPluginFunction impl = Libs.AlliedMods.GetClass<IIPluginFunction,_IPluginFunction,IPluginFunction> ("IPluginFunction");

		[MangleAs ("class SourcePawn::IPluginFunction")]
		public partial interface IIPluginFunction : ICppClassOverridable<IPluginFunction> {
			[Virtual] int Execute (CppInstancePtr @this, out int result);
			[Virtual] int CallFunction (CppInstancePtr @this, IntPtr @params, uint num_params, out int result);
			[Virtual] SourcePawn.IPluginContext GetParentContext (CppInstancePtr @this);
			[Virtual] bool IsRunnable (CppInstancePtr @this);
			[Virtual] uint GetFunctionID (CppInstancePtr @this);
			[Virtual] int Execute2 (CppInstancePtr @this, SourcePawn.IPluginContext ctx, out int result);
			[Virtual] int CallFunction2 (CppInstancePtr @this, SourcePawn.IPluginContext ctx, IntPtr @params, uint num_params, out int result);
			[Virtual] SourcePawn.IPluginRuntime GetParentRuntime (CppInstancePtr @this);
		}
		public unsafe struct _IPluginFunction {
		}




		public IPluginFunction (CppTypeInfo subClass)
			: base (impl.TypeInfo)
		{
			__cxxi_LayoutClass ();
			subClass.AddBase (impl.TypeInfo);
		}

		public IPluginFunction (CppInstancePtr native)
			: base (impl.TypeInfo)
		{
			__cxxi_LayoutClass ();
			Native = native;
		}

		[OverrideNative ("Execute")]
		public virtual int Execute (out int result)
		{
			return impl.Execute (Native, out result);
		}
		[OverrideNative ("CallFunction")]
		public virtual int CallFunction (IntPtr @params, uint num_params, out int result)
		{
			return impl.CallFunction (Native, @params, num_params, out result);
		}
		[OverrideNative ("GetParentContext")]
		public virtual SourcePawn.IPluginContext GetParentContext ()
		{
			return impl.GetParentContext (Native);
		}
		[OverrideNative ("IsRunnable")]
		public virtual bool IsRunnable ()
		{
			return impl.IsRunnable (Native);
		}
		[OverrideNative ("GetFunctionID")]
		public virtual uint GetFunctionID ()
		{
			return impl.GetFunctionID (Native);
		}
		[OverrideNative ("Execute2")]
		public virtual int Execute2 (SourcePawn.IPluginContext ctx, out int result)
		{
			return impl.Execute2 (Native, ctx, out result);
		}
		[OverrideNative ("CallFunction2")]
		public virtual int CallFunction2 (SourcePawn.IPluginContext ctx, IntPtr @params, uint num_params, out int result)
		{
			return impl.CallFunction2 (Native, ctx, @params, num_params, out result);
		}
		[OverrideNative ("GetParentRuntime")]
		public virtual SourcePawn.IPluginRuntime GetParentRuntime ()
		{
			return impl.GetParentRuntime (Native);
		}


		partial void BeforeDestruct ();
		partial void AfterDestruct ();

		public override void Dispose ()
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

