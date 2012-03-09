// -------------------------------------------------------------------------
//  Managed wrapper for ISourcePawnEngine
//  Generated from bindings.xml on 02/28/2012 15:56:54
//
//  This file was auto generated. Do not edit.
// -------------------------------------------------------------------------

using System;
using Mono.Cxxi;

namespace AlliedMods.SourcePawn {
	public partial class ISourcePawnEngine : ICppObject {

		private static readonly IISourcePawnEngine impl = Libs.AlliedMods.GetClass<IISourcePawnEngine,_ISourcePawnEngine,ISourcePawnEngine> ("ISourcePawnEngine");
		public CppInstancePtr Native { get; protected set; }

		[MangleAs ("class SourcePawn::ISourcePawnEngine")]
		public partial interface IISourcePawnEngine : ICppClassOverridable<ISourcePawnEngine> {
			[Virtual] void LoadFromFilePointer (CppInstancePtr @this, _IO_FILE fp, ref int err);
			[Virtual] void LoadFromMemory (CppInstancePtr @this, IntPtr @base, IntPtr plugin, ref int err);
			[Virtual] int FreeFromMemory (CppInstancePtr @this, IntPtr plugin);
			[Virtual] IntPtr BaseAlloc (CppInstancePtr @this, uint size);
			[Virtual] void BaseFree (CppInstancePtr @this, IntPtr memory);
			[Virtual] IntPtr ExecAlloc (CppInstancePtr @this, uint size);
			[Virtual] void ExecFree (CppInstancePtr @this, IntPtr address);
			[Virtual] SourcePawn.IDebugListener SetDebugListener (CppInstancePtr @this, SourcePawn.IDebugListener listener);
			[Virtual] uint GetContextCallCount (CppInstancePtr @this);
			[Virtual] uint GetEngineAPIVersion (CppInstancePtr @this);
			[Virtual] IntPtr AllocatePageMemory (CppInstancePtr @this, uint size);
			[Virtual] void SetReadWrite (CppInstancePtr @this, IntPtr ptr);
			[Virtual] void SetReadExecute (CppInstancePtr @this, IntPtr ptr);
			[Virtual] void FreePageMemory (CppInstancePtr @this, IntPtr ptr);
		}
		public unsafe struct _ISourcePawnEngine {
		}




		public ISourcePawnEngine (CppTypeInfo subClass)
		{
			__cxxi_LayoutClass ();
			subClass.AddBase (impl.TypeInfo);
		}

		public ISourcePawnEngine (CppInstancePtr native)
		{
			__cxxi_LayoutClass ();
			Native = native;
		}

		[OverrideNative ("BaseAlloc")]
		public virtual IntPtr BaseAlloc (uint size)
		{
			return impl.BaseAlloc (Native, size);
		}
		[OverrideNative ("BaseFree")]
		public virtual void BaseFree (IntPtr memory)
		{
			impl.BaseFree (Native, memory);
		}
		[OverrideNative ("ExecAlloc")]
		public virtual IntPtr ExecAlloc (uint size)
		{
			return impl.ExecAlloc (Native, size);
		}
		[OverrideNative ("ExecFree")]
		public virtual void ExecFree (IntPtr address)
		{
			impl.ExecFree (Native, address);
		}
		[OverrideNative ("SetDebugListener")]
		public virtual SourcePawn.IDebugListener SetDebugListener (SourcePawn.IDebugListener listener)
		{
			return impl.SetDebugListener (Native, listener);
		}
		[OverrideNative ("GetContextCallCount")]
		public virtual uint GetContextCallCount ()
		{
			return impl.GetContextCallCount (Native);
		}
		[OverrideNative ("GetEngineAPIVersion")]
		public virtual uint GetEngineAPIVersion ()
		{
			return impl.GetEngineAPIVersion (Native);
		}
		[OverrideNative ("AllocatePageMemory")]
		public virtual IntPtr AllocatePageMemory (uint size)
		{
			return impl.AllocatePageMemory (Native, size);
		}
		[OverrideNative ("SetReadWrite")]
		public virtual void SetReadWrite (IntPtr ptr)
		{
			impl.SetReadWrite (Native, ptr);
		}
		[OverrideNative ("SetReadExecute")]
		public virtual void SetReadExecute (IntPtr ptr)
		{
			impl.SetReadExecute (Native, ptr);
		}
		[OverrideNative ("FreePageMemory")]
		public virtual void FreePageMemory (IntPtr ptr)
		{
			impl.FreePageMemory (Native, ptr);
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

