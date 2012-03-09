// -------------------------------------------------------------------------
//  Managed wrapper for IDataPack
//  Generated from bindings.xml on 02/28/2012 15:56:54
//
//  This file was auto generated. Do not edit.
// -------------------------------------------------------------------------

using System;
using Mono.Cxxi;

namespace AlliedMods.SourceMod {
	public partial class IDataPack : IDataReader {

		private static readonly IIDataPack impl = Libs.AlliedMods.GetClass<IIDataPack,_IDataPack,IDataPack> ("IDataPack");

		[MangleAs ("class SourceMod::IDataPack")]
		public partial interface IIDataPack : ICppClassOverridable<IDataPack> {
			[Virtual] void ResetSize (CppInstancePtr @this);
			[Virtual] void PackCell (CppInstancePtr @this, int cell);
			[Virtual] void PackFloat (CppInstancePtr @this, float val);
			[Virtual] void PackString (CppInstancePtr @this, string @string);
			[Virtual] uint CreateMemory (CppInstancePtr @this, uint size, IntPtr addr);
		}
		public unsafe struct _IDataPack {
		}




		public IDataPack (CppTypeInfo subClass)
			: base (impl.TypeInfo)
		{
			__cxxi_LayoutClass ();
			subClass.AddBase (impl.TypeInfo);
		}

		public IDataPack (CppInstancePtr native)
			: base (impl.TypeInfo)
		{
			__cxxi_LayoutClass ();
			Native = native;
		}

		[OverrideNative ("ResetSize")]
		public virtual void ResetSize ()
		{
			impl.ResetSize (Native);
		}
		[OverrideNative ("PackCell")]
		public virtual void PackCell (int cell)
		{
			impl.PackCell (Native, cell);
		}
		[OverrideNative ("PackFloat")]
		public virtual void PackFloat (float val)
		{
			impl.PackFloat (Native, val);
		}
		[OverrideNative ("PackString")]
		public virtual void PackString (string @string)
		{
			impl.PackString (Native, @string);
		}
		[OverrideNative ("CreateMemory")]
		public virtual uint CreateMemory (uint size, IntPtr addr)
		{
			return impl.CreateMemory (Native, size, addr);
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

