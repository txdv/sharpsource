// -------------------------------------------------------------------------
//  Managed wrapper for IPluginDebugInfo
//  Generated from bindings.xml on 02/28/2012 15:56:54
//
//  This file was auto generated. Do not edit.
// -------------------------------------------------------------------------

using System;
using Mono.Cxxi;

namespace AlliedMods.SourcePawn {
	public partial class IPluginDebugInfo : ICppObject {

		private static readonly IIPluginDebugInfo impl = Libs.AlliedMods.GetClass<IIPluginDebugInfo,_IPluginDebugInfo,IPluginDebugInfo> ("IPluginDebugInfo");
		public CppInstancePtr Native { get; protected set; }

		[MangleAs ("class SourcePawn::IPluginDebugInfo")]
		public partial interface IIPluginDebugInfo : ICppClassOverridable<IPluginDebugInfo> {
			[Virtual] int LookupFile (CppInstancePtr @this, uint addr, String[] filename);
			[Virtual] int LookupFunction (CppInstancePtr @this, uint addr, String[] name);
			[Virtual] int LookupLine (CppInstancePtr @this, uint addr, ref uint line);
		}
		public unsafe struct _IPluginDebugInfo {
		}




		public IPluginDebugInfo (CppTypeInfo subClass)
		{
			__cxxi_LayoutClass ();
			subClass.AddBase (impl.TypeInfo);
		}

		public IPluginDebugInfo (CppInstancePtr native)
		{
			__cxxi_LayoutClass ();
			Native = native;
		}

		[OverrideNative ("LookupFile")]
		public virtual int LookupFile (uint addr, String[] filename)
		{
			return impl.LookupFile (Native, addr, filename);
		}
		[OverrideNative ("LookupFunction")]
		public virtual int LookupFunction (uint addr, String[] name)
		{
			return impl.LookupFunction (Native, addr, name);
		}
		[OverrideNative ("LookupLine")]
		public virtual int LookupLine (uint addr, ref uint line)
		{
			return impl.LookupLine (Native, addr, ref line);
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

