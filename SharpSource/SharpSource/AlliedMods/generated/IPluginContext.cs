// -------------------------------------------------------------------------
//  Managed wrapper for IPluginContext
//  Generated from bindings.xml on 02/28/2012 15:56:54
//
//  This file was auto generated. Do not edit.
// -------------------------------------------------------------------------

using System;
using Mono.Cxxi;

namespace AlliedMods.SourcePawn {
	public partial class IPluginContext : ICppObject {

		private static readonly IIPluginContext impl = Libs.AlliedMods.GetClass<IIPluginContext,_IPluginContext,IPluginContext> ("IPluginContext");
		public CppInstancePtr Native { get; protected set; }

		[MangleAs ("class SourcePawn::IPluginContext")]
		public partial interface IIPluginContext : ICppClassOverridable<IPluginContext> {
			[Virtual] [Inline] [Destructor] void Destruct (CppInstancePtr @this);
			[Virtual] void GetVirtualMachine (CppInstancePtr @this);
			[Virtual] void GetContext (CppInstancePtr @this);
			[Virtual] bool IsDebugging (CppInstancePtr @this);
			[Virtual] int SetDebugBreak (CppInstancePtr @this, IntPtr newpfn, IntPtr oldpfn);
			[Virtual] SourcePawn.IPluginDebugInfo GetDebugInfo (CppInstancePtr @this);
			[Virtual] int HeapAlloc (CppInstancePtr @this, uint cells, ref int local_addr, IntPtr phys_addr);
			[Virtual] int HeapPop (CppInstancePtr @this, int local_addr);
			[Virtual] int HeapRelease (CppInstancePtr @this, int local_addr);
			[Virtual] int FindNativeByName (CppInstancePtr @this, string name, out uint index);
			[Virtual] int GetNativeByIndex (CppInstancePtr @this, uint index, IntPtr native);
			[Virtual] uint GetNativesNum (CppInstancePtr @this);
			[Virtual] int FindPublicByName (CppInstancePtr @this, string name, ref uint index);
			[Virtual] int GetPublicByIndex (CppInstancePtr @this, uint index, IntPtr publicptr);
			[Virtual] uint GetPublicsNum (CppInstancePtr @this);
			[Virtual] int GetPubvarByIndex (CppInstancePtr @this, uint index, IntPtr pubvar);
			[Virtual] int FindPubvarByName (CppInstancePtr @this, string name, ref uint index);
			[Virtual] int GetPubvarAddrs (CppInstancePtr @this, uint index, ref int local_addr, IntPtr phys_addr);
			[Virtual] uint GetPubVarsNum (CppInstancePtr @this);
			[Virtual] int LocalToPhysAddr (CppInstancePtr @this, int local_addr, IntPtr phys_addr);
			[Virtual] int LocalToString (CppInstancePtr @this, int local_addr, out IntPtr addr);
			[Virtual] int StringToLocal (CppInstancePtr @this, int local_addr, uint bytes, string source);
			[Virtual] int StringToLocalUTF8 (CppInstancePtr @this, int local_addr, uint maxbytes, string source, out uint wrtnbytes);
			[Virtual] int PushCell (CppInstancePtr @this, int value);
			[Virtual] int PushCellArray (CppInstancePtr @this, ref int local_addr, IntPtr phys_addr, ref int array, uint numcells);
			[Virtual] int PushString (CppInstancePtr @this, ref int local_addr, String[] phys_addr, string @string);
			[Virtual] int PushCellsFromArray (CppInstancePtr @this, ref int array, uint numcells);
			[Virtual] int BindNatives (CppInstancePtr @this, sp_nativeinfo_s natives, uint num, int overwrite);
			[Virtual] int BindNative (CppInstancePtr @this, sp_nativeinfo_s native);
			[Virtual] int BindNativeToAny (CppInstancePtr @this, IntPtr native);
			[Virtual] int Execute (CppInstancePtr @this, uint code_addr, out int result);
			[Virtual] int ThrowNativeErrorEx (CppInstancePtr @this, int error, string msg);
			[Virtual] int ThrowNativeError (CppInstancePtr @this, string msg);
			[Virtual] SourcePawn.IPluginFunction GetFunctionByName (CppInstancePtr @this, string public_name);
			[Virtual] SourcePawn.IPluginFunction GetFunctionById (CppInstancePtr @this, uint func_id);
			[Virtual] void GetIdentity (CppInstancePtr @this);
			[Virtual] [return: ByRef] int GetNullRef (CppInstancePtr @this, SourcePawn.SP_NULL_TYPE type);
			[Virtual] int LocalToStringNULL (CppInstancePtr @this, int local_addr, String[] addr);
			[Virtual] int BindNativeToIndex (CppInstancePtr @this, uint index, IntPtr native);
			[Virtual] bool IsInExec (CppInstancePtr @this);
			[Virtual] SourcePawn.IPluginRuntime GetRuntime (CppInstancePtr @this);
			[Virtual] int Execute2 (CppInstancePtr @this, SourcePawn.IPluginFunction function, IntPtr @params, uint num_params, out int result);
			[Virtual] int GetLastNativeError (CppInstancePtr @this);
			[Virtual] [return: ByRef] int GetLocalParams (CppInstancePtr @this);
			[Virtual] void SetKey (CppInstancePtr @this, int k, IntPtr value);
			[Virtual] bool GetKey (CppInstancePtr @this, int k, IntPtr value);
			[Virtual] void ClearLastNativeError (CppInstancePtr @this);
		}
		public unsafe struct _IPluginContext {
		}


		public IPluginContext (CppTypeInfo subClass)
		{
			__cxxi_LayoutClass ();
			subClass.AddBase (impl.TypeInfo);
		}

		public IPluginContext (CppInstancePtr native)
		{
			__cxxi_LayoutClass ();
			Native = native;
		}

		[OverrideNative ("IsDebugging")]
		public virtual bool IsDebugging ()
		{
			return impl.IsDebugging (Native);
		}
		[OverrideNative ("SetDebugBreak")]
		public virtual int SetDebugBreak (IntPtr newpfn, IntPtr oldpfn)
		{
			return impl.SetDebugBreak (Native, newpfn, oldpfn);
		}
		[OverrideNative ("GetDebugInfo")]
		public virtual SourcePawn.IPluginDebugInfo GetDebugInfo ()
		{
			return impl.GetDebugInfo (Native);
		}
		[OverrideNative ("HeapAlloc")]
		public virtual int HeapAlloc (uint cells, ref int local_addr, IntPtr phys_addr)
		{
			return impl.HeapAlloc (Native, cells, ref local_addr, phys_addr);
		}
		[OverrideNative ("HeapPop")]
		public virtual int HeapPop (int local_addr)
		{
			return impl.HeapPop (Native, local_addr);
		}
		[OverrideNative ("HeapRelease")]
		public virtual int HeapRelease (int local_addr)
		{
			return impl.HeapRelease (Native, local_addr);
		}
		[OverrideNative ("FindNativeByName")]
		public virtual int FindNativeByName (string name, out uint index)
		{
			return impl.FindNativeByName (Native, name, out index);
		}
		[OverrideNative ("GetNativeByIndex")]
		public virtual int GetNativeByIndex (uint index, IntPtr native)
		{
			return impl.GetNativeByIndex (Native, index, native);
		}
		[OverrideNative ("GetNativesNum")]
		public virtual uint GetNativesNum ()
		{
			return impl.GetNativesNum (Native);
		}
		[OverrideNative ("FindPublicByName")]
		public virtual int FindPublicByName (string name, ref uint index)
		{
			return impl.FindPublicByName (Native, name, ref index);
		}
		[OverrideNative ("GetPublicByIndex")]
		public virtual int GetPublicByIndex (uint index, IntPtr publicptr)
		{
			return impl.GetPublicByIndex (Native, index, publicptr);
		}
		[OverrideNative ("GetPublicsNum")]
		public virtual uint GetPublicsNum ()
		{
			return impl.GetPublicsNum (Native);
		}
		[OverrideNative ("GetPubvarByIndex")]
		public virtual int GetPubvarByIndex (uint index, IntPtr pubvar)
		{
			return impl.GetPubvarByIndex (Native, index, pubvar);
		}
		[OverrideNative ("FindPubvarByName")]
		public virtual int FindPubvarByName (string name, ref uint index)
		{
			return impl.FindPubvarByName (Native, name, ref index);
		}
		[OverrideNative ("GetPubvarAddrs")]
		public virtual int GetPubvarAddrs (uint index, ref int local_addr, IntPtr phys_addr)
		{
			return impl.GetPubvarAddrs (Native, index, ref local_addr, phys_addr);
		}
		[OverrideNative ("GetPubVarsNum")]
		public virtual uint GetPubVarsNum ()
		{
			return impl.GetPubVarsNum (Native);
		}
		[OverrideNative ("LocalToPhysAddr")]
		public virtual int LocalToPhysAddr (int local_addr, IntPtr phys_addr)
		{
			return impl.LocalToPhysAddr (Native, local_addr, phys_addr);
		}
		[OverrideNative ("LocalToString")]
		public virtual int LocalToString (int local_addr, out IntPtr addr)
		{
			return impl.LocalToString (Native, local_addr, out addr);
		}
		[OverrideNative ("StringToLocal")]
		public virtual int StringToLocal (int local_addr, uint bytes, string source)
		{
			return impl.StringToLocal (Native, local_addr, bytes, source);
		}
		[OverrideNative ("StringToLocalUTF8")]
		public virtual int StringToLocalUTF8 (int local_addr, uint maxbytes, string source, out uint wrtnbytes)
		{
			return impl.StringToLocalUTF8 (Native, local_addr, maxbytes, source, out wrtnbytes);
		}
		[OverrideNative ("PushCell")]
		public virtual int PushCell (int value)
		{
			return impl.PushCell (Native, value);
		}
		[OverrideNative ("PushCellArray")]
		public virtual int PushCellArray (ref int local_addr, IntPtr phys_addr, ref int array, uint numcells)
		{
			return impl.PushCellArray (Native, ref local_addr, phys_addr, ref array, numcells);
		}
		[OverrideNative ("PushString")]
		public virtual int PushString (ref int local_addr, String[] phys_addr, string @string)
		{
			return impl.PushString (Native, ref local_addr, phys_addr, @string);
		}
		[OverrideNative ("PushCellsFromArray")]
		public virtual int PushCellsFromArray (ref int array, uint numcells)
		{
			return impl.PushCellsFromArray (Native, ref array, numcells);
		}
		[OverrideNative ("BindNatives")]
		public virtual int BindNatives (sp_nativeinfo_s natives, uint num, int overwrite)
		{
			return impl.BindNatives (Native, natives, num, overwrite);
		}
		[OverrideNative ("BindNative")]
		public virtual int BindNative (sp_nativeinfo_s native)
		{
			return impl.BindNative (Native, native);
		}
		[OverrideNative ("Execute")]
		public virtual int Execute (uint code_addr, out int result)
		{
			return impl.Execute (Native, code_addr, out result);
		}
		[OverrideNative ("ThrowNativeErrorEx")]
		public virtual int ThrowNativeErrorEx (int error, string msg)
		{
			return impl.ThrowNativeErrorEx (Native, error, msg);
		}
		[OverrideNative ("ThrowNativeError")]
		public virtual int ThrowNativeError (string msg)
		{
			return impl.ThrowNativeError (Native, msg);
		}
		[OverrideNative ("GetFunctionByName")]
		public virtual SourcePawn.IPluginFunction GetFunctionByName (string public_name)
		{
			return impl.GetFunctionByName (Native, public_name);
		}
		[OverrideNative ("GetFunctionById")]
		public virtual SourcePawn.IPluginFunction GetFunctionById (uint func_id)
		{
			return impl.GetFunctionById (Native, func_id);
		}
		[OverrideNative ("GetNullRef")]
		public virtual int GetNullRef (SourcePawn.SP_NULL_TYPE type)
		{
			return impl.GetNullRef (Native, type);
		}
		[OverrideNative ("LocalToStringNULL")]
		public virtual int LocalToStringNULL (int local_addr, String[] addr)
		{
			return impl.LocalToStringNULL (Native, local_addr, addr);
		}
		[OverrideNative ("IsInExec")]
		public virtual bool IsInExec ()
		{
			return impl.IsInExec (Native);
		}
		[OverrideNative ("GetRuntime")]
		public virtual SourcePawn.IPluginRuntime GetRuntime ()
		{
			return impl.GetRuntime (Native);
		}
		[OverrideNative ("Execute2")]
		public virtual int Execute2 (SourcePawn.IPluginFunction function, IntPtr @params, uint num_params, out int result)
		{
			return impl.Execute2 (Native, function, @params, num_params, out result);
		}
		[OverrideNative ("GetLastNativeError")]
		public virtual int GetLastNativeError ()
		{
			return impl.GetLastNativeError (Native);
		}
		[OverrideNative ("GetLocalParams")]
		public virtual int GetLocalParams ()
		{
			return impl.GetLocalParams (Native);
		}
		[OverrideNative ("SetKey")]
		public virtual void SetKey (int k, IntPtr value)
		{
			impl.SetKey (Native, k, value);
		}
		[OverrideNative ("GetKey")]
		public virtual bool GetKey (int k, IntPtr value)
		{
			return impl.GetKey (Native, k, value);
		}
		[OverrideNative ("ClearLastNativeError")]
		public virtual void ClearLastNativeError ()
		{
			impl.ClearLastNativeError (Native);
		}


		partial void BeforeDestruct ();
		partial void AfterDestruct ();

		public virtual void Dispose ()
		{
			BeforeDestruct ();
			impl.Destruct (Native);
			Native.Dispose ();
			AfterDestruct ();
		}

		private void __cxxi_LayoutClass ()
		{
			impl.TypeInfo.CompleteType ();
		}

	}
}

