// -------------------------------------------------------------------------
//  Managed wrapper for IDataReader
//  Generated from bindings.xml on 02/28/2012 15:56:54
//
//  This file was auto generated. Do not edit.
// -------------------------------------------------------------------------

using System;
using Mono.Cxxi;

namespace AlliedMods.SourceMod {
	public partial class IDataReader : ICppObject {

		private static readonly IIDataReader impl = Libs.AlliedMods.GetClass<IIDataReader,_IDataReader,IDataReader> ("IDataReader");
		public CppInstancePtr Native { get; protected set; }

		[MangleAs ("class SourceMod::IDataReader")]
		public partial interface IIDataReader : ICppClassOverridable<IDataReader> {
			[Virtual] [Const] void Reset (CppInstancePtr @this);
			[Virtual] [Const] uint GetPosition (CppInstancePtr @this);
			[Virtual] [Const] bool SetPosition (CppInstancePtr @this, uint pos);
			[Virtual] [Const] int ReadCell (CppInstancePtr @this);
			[Virtual] [Const] float ReadFloat (CppInstancePtr @this);
			[Virtual] [Const] bool IsReadable (CppInstancePtr @this, uint bytes);
			[Virtual] [Const] string ReadString (CppInstancePtr @this, ref uint len);
			[Virtual] [Const] IntPtr GetMemory (CppInstancePtr @this);
			[Virtual] [Const] IntPtr ReadMemory (CppInstancePtr @this, ref uint size);
		}
		public unsafe struct _IDataReader {
		}




		public IDataReader (CppTypeInfo subClass)
		{
			__cxxi_LayoutClass ();
			subClass.AddBase (impl.TypeInfo);
		}

		public IDataReader (CppInstancePtr native)
		{
			__cxxi_LayoutClass ();
			Native = native;
		}

		[OverrideNative ("Reset")]
		public virtual void Reset ()
		{
			impl.Reset (Native);
		}
		[OverrideNative ("SetPosition")]
		public virtual bool SetPosition (uint pos)
		{
			return impl.SetPosition (Native, pos);
		}
		[OverrideNative ("IsReadable")]
		public virtual bool IsReadable (uint bytes)
		{
			return impl.IsReadable (Native, bytes);
		}
		[OverrideNative ("ReadString")]
		public virtual string ReadString (ref uint len)
		{
			return impl.ReadString (Native, ref len);
		}
		[OverrideNative ("ReadMemory")]
		public virtual IntPtr ReadMemory (ref uint size)
		{
			return impl.ReadMemory (Native, ref size);
		}

		public virtual uint GetPosition {
			[OverrideNative ("GetPosition")] get {
				return impl.GetPosition (Native);
			}
		}

		public virtual int ReadCell {
			[OverrideNative ("ReadCell")] get {
				return impl.ReadCell (Native);
			}
		}

		public virtual float ReadFloat {
			[OverrideNative ("ReadFloat")] get {
				return impl.ReadFloat (Native);
			}
		}

		public virtual IntPtr GetMemory {
			[OverrideNative ("GetMemory")] get {
				return impl.GetMemory (Native);
			}
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

