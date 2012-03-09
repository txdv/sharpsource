// -------------------------------------------------------------------------
//  Managed wrapper for ILibrarySys
//  Generated from bindings.xml on 02/28/2012 15:56:54
//
//  This file was auto generated. Do not edit.
// -------------------------------------------------------------------------

using System;
using Mono.Cxxi;

namespace AlliedMods.SourceMod {
	public partial class ILibrarySys : SMInterface {

		private static readonly IILibrarySys impl = Libs.AlliedMods.GetClass<IILibrarySys,_ILibrarySys,ILibrarySys> ("ILibrarySys");

		[MangleAs ("class SourceMod::ILibrarySys")]
		public partial interface IILibrarySys : ICppClassOverridable<ILibrarySys> {
			[Virtual] SourceMod.ILibrary OpenLibrary (CppInstancePtr @this, string path, string error, uint maxlength);
			[Virtual] SourceMod.IDirectory OpenDirectory (CppInstancePtr @this, string path);
			[Virtual] void CloseDirectory (CppInstancePtr @this, SourceMod.IDirectory dir);
			[Virtual] bool PathExists (CppInstancePtr @this, string path);
			[Virtual] bool IsPathFile (CppInstancePtr @this, string path);
			[Virtual] bool IsPathDirectory (CppInstancePtr @this, string path);
			[Virtual] void GetPlatformError (CppInstancePtr @this, string error, uint maxlength);
			[Virtual] uint PathFormat (CppInstancePtr @this, string buffer, uint maxlength, string pathfmt);
			[Virtual] string GetFileExtension (CppInstancePtr @this, string filename);
			[Virtual] bool CreateFolder (CppInstancePtr @this, string path);
			[Virtual] bool FileTime (CppInstancePtr @this, string path, SourceMod.FileTimeType type, ref int pTime);
		}
		public unsafe struct _ILibrarySys {
		}




		public ILibrarySys (CppTypeInfo subClass)
			: base (impl.TypeInfo)
		{
			__cxxi_LayoutClass ();
			subClass.AddBase (impl.TypeInfo);
		}

		public ILibrarySys (CppInstancePtr native)
			: base (impl.TypeInfo)
		{
			__cxxi_LayoutClass ();
			Native = native;
		}

		[OverrideNative ("OpenLibrary")]
		public virtual SourceMod.ILibrary OpenLibrary (string path, string error, uint maxlength)
		{
			return impl.OpenLibrary (Native, path, error, maxlength);
		}
		[OverrideNative ("OpenDirectory")]
		public virtual SourceMod.IDirectory OpenDirectory (string path)
		{
			return impl.OpenDirectory (Native, path);
		}
		[OverrideNative ("CloseDirectory")]
		public virtual void CloseDirectory (SourceMod.IDirectory dir)
		{
			impl.CloseDirectory (Native, dir);
		}
		[OverrideNative ("PathExists")]
		public virtual bool PathExists (string path)
		{
			return impl.PathExists (Native, path);
		}
		[OverrideNative ("IsPathFile")]
		public virtual bool IsPathFile (string path)
		{
			return impl.IsPathFile (Native, path);
		}
		[OverrideNative ("IsPathDirectory")]
		public virtual bool IsPathDirectory (string path)
		{
			return impl.IsPathDirectory (Native, path);
		}
		[OverrideNative ("GetPlatformError")]
		public virtual void GetPlatformError (string error, uint maxlength)
		{
			impl.GetPlatformError (Native, error, maxlength);
		}
		[OverrideNative ("PathFormat")]
		public virtual uint PathFormat (string buffer, uint maxlength, string pathfmt)
		{
			return impl.PathFormat (Native, buffer, maxlength, pathfmt);
		}
		[OverrideNative ("GetFileExtension")]
		public virtual string GetFileExtension (string filename)
		{
			return impl.GetFileExtension (Native, filename);
		}
		[OverrideNative ("CreateFolder")]
		public virtual bool CreateFolder (string path)
		{
			return impl.CreateFolder (Native, path);
		}
		[OverrideNative ("FileTime")]
		public virtual bool FileTime (string path, SourceMod.FileTimeType type, ref int pTime)
		{
			return impl.FileTime (Native, path, type, ref pTime);
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

