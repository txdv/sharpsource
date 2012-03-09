// -------------------------------------------------------------------------
//  Managed wrapper for ISourcePawnEngine2
//  Generated from bindings.xml on 02/28/2012 15:56:54
//
//  This file was auto generated. Do not edit.
// -------------------------------------------------------------------------

using System;
using Mono.Cxxi;

namespace AlliedMods.SourcePawn {
	public partial class ISourcePawnEngine2 : ICppObject {

		private static readonly IISourcePawnEngine2 impl = Libs.AlliedMods.GetClass<IISourcePawnEngine2,_ISourcePawnEngine2,ISourcePawnEngine2> ("ISourcePawnEngine2");
		public CppInstancePtr Native { get; protected set; }

		[MangleAs ("class SourcePawn::ISourcePawnEngine2")]
		public partial interface IISourcePawnEngine2 : ICppClassOverridable<ISourcePawnEngine2> {
			[Virtual] uint GetAPIVersion (CppInstancePtr @this);
			[Virtual] string GetEngineName (CppInstancePtr @this);
			[Virtual] string GetVersionString (CppInstancePtr @this);
			[Virtual] SourcePawn.ICompilation StartCompilation (CppInstancePtr @this);
			[Virtual] SourcePawn.IPluginRuntime LoadPlugin (CppInstancePtr @this, SourcePawn.ICompilation co, string file, ref int err);
			[Virtual] void CreateFakeNative (CppInstancePtr @this, IntPtr callback, IntPtr pData);
			[Virtual] void DestroyFakeNative (CppInstancePtr @this, IntPtr func);
			[Virtual] SourcePawn.IDebugListener SetDebugListener (CppInstancePtr @this, SourcePawn.IDebugListener listener);
			[Virtual] void SetProfiler (CppInstancePtr @this, SourcePawn.IProfiler profiler);
			[Virtual] string GetErrorString (CppInstancePtr @this, int err);
			[Virtual] bool Initialize (CppInstancePtr @this);
			[Virtual] void Shutdown (CppInstancePtr @this);
			[Virtual] SourcePawn.IPluginRuntime CreateEmptyRuntime (CppInstancePtr @this, string name, uint memory);
		}
		public unsafe struct _ISourcePawnEngine2 {
		}




		public ISourcePawnEngine2 (CppTypeInfo subClass)
		{
			__cxxi_LayoutClass ();
			subClass.AddBase (impl.TypeInfo);
		}

		public ISourcePawnEngine2 (CppInstancePtr native)
		{
			__cxxi_LayoutClass ();
			Native = native;
		}

		[OverrideNative ("GetAPIVersion")]
		public virtual uint GetAPIVersion ()
		{
			return impl.GetAPIVersion (Native);
		}
		[OverrideNative ("GetEngineName")]
		public virtual string GetEngineName ()
		{
			return impl.GetEngineName (Native);
		}
		[OverrideNative ("GetVersionString")]
		public virtual string GetVersionString ()
		{
			return impl.GetVersionString (Native);
		}
		[OverrideNative ("StartCompilation")]
		public virtual SourcePawn.ICompilation StartCompilation ()
		{
			return impl.StartCompilation (Native);
		}
		[OverrideNative ("LoadPlugin")]
		public virtual SourcePawn.IPluginRuntime LoadPlugin (SourcePawn.ICompilation co, string file, ref int err)
		{
			return impl.LoadPlugin (Native, co, file, ref err);
		}
		[OverrideNative ("SetDebugListener")]
		public virtual SourcePawn.IDebugListener SetDebugListener (SourcePawn.IDebugListener listener)
		{
			return impl.SetDebugListener (Native, listener);
		}
		[OverrideNative ("SetProfiler")]
		public virtual void SetProfiler (SourcePawn.IProfiler profiler)
		{
			impl.SetProfiler (Native, profiler);
		}
		[OverrideNative ("GetErrorString")]
		public virtual string GetErrorString (int err)
		{
			return impl.GetErrorString (Native, err);
		}
		[OverrideNative ("Initialize")]
		public virtual bool Initialize ()
		{
			return impl.Initialize (Native);
		}
		[OverrideNative ("Shutdown")]
		public virtual void Shutdown ()
		{
			impl.Shutdown (Native);
		}
		[OverrideNative ("CreateEmptyRuntime")]
		public virtual SourcePawn.IPluginRuntime CreateEmptyRuntime (string name, uint memory)
		{
			return impl.CreateEmptyRuntime (Native, name, memory);
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

