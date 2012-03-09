// -------------------------------------------------------------------------
//  Managed wrapper for IDirectory
//  Generated from bindings.xml on 02/28/2012 15:56:54
//
//  This file was auto generated. Do not edit.
// -------------------------------------------------------------------------

using System;
using Mono.Cxxi;

namespace AlliedMods.SourceMod {
	public partial class IDirectory : ICppObject {

		private static readonly IIDirectory impl = Libs.AlliedMods.GetClass<IIDirectory,_IDirectory,IDirectory> ("IDirectory");
		public CppInstancePtr Native { get; protected set; }

		[MangleAs ("class SourceMod::IDirectory")]
		public partial interface IIDirectory : ICppClassOverridable<IDirectory> {
			[Virtual] [Inline] [Destructor] void Destruct (CppInstancePtr @this);
			[Virtual] bool MoreFiles (CppInstancePtr @this);
			[Virtual] void NextEntry (CppInstancePtr @this);
			[Virtual] string GetEntryName (CppInstancePtr @this);
			[Virtual] bool IsEntryDirectory (CppInstancePtr @this);
			[Virtual] bool IsEntryFile (CppInstancePtr @this);
			[Virtual] bool IsEntryValid (CppInstancePtr @this);
		}
		public unsafe struct _IDirectory {
		}




		public IDirectory (CppTypeInfo subClass)
		{
			__cxxi_LayoutClass ();
			subClass.AddBase (impl.TypeInfo);
		}

		public IDirectory (CppInstancePtr native)
		{
			__cxxi_LayoutClass ();
			Native = native;
		}

		[OverrideNative ("MoreFiles")]
		public virtual bool MoreFiles ()
		{
			return impl.MoreFiles (Native);
		}
		[OverrideNative ("NextEntry")]
		public virtual void NextEntry ()
		{
			impl.NextEntry (Native);
		}
		[OverrideNative ("GetEntryName")]
		public virtual string GetEntryName ()
		{
			return impl.GetEntryName (Native);
		}
		[OverrideNative ("IsEntryDirectory")]
		public virtual bool IsEntryDirectory ()
		{
			return impl.IsEntryDirectory (Native);
		}
		[OverrideNative ("IsEntryFile")]
		public virtual bool IsEntryFile ()
		{
			return impl.IsEntryFile (Native);
		}
		[OverrideNative ("IsEntryValid")]
		public virtual bool IsEntryValid ()
		{
			return impl.IsEntryValid (Native);
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

