// -------------------------------------------------------------------------
//  Managed wrapper for ICallable
//  Generated from bindings.xml on 02/28/2012 15:56:54
//
//  This file was auto generated. Do not edit.
// -------------------------------------------------------------------------

using System;
using Mono.Cxxi;

namespace AlliedMods.SourcePawn {
	public partial class ICallable : ICppObject {

		private static readonly IICallable impl = Libs.AlliedMods.GetClass<IICallable,_ICallable,ICallable> ("ICallable");
		public CppInstancePtr Native { get; protected set; }

		[MangleAs ("class SourcePawn::ICallable")]
		public partial interface IICallable : ICppClassOverridable<ICallable> {
			[Virtual] int PushCell (CppInstancePtr @this, int cell);
			[Virtual] int PushCellByRef (CppInstancePtr @this, ref int cell, int flags);
			[Virtual] int PushFloat (CppInstancePtr @this, float number);
			[Virtual] int PushFloatByRef (CppInstancePtr @this, ref float number, int flags);
			[Virtual] int PushArray (CppInstancePtr @this, ref int inarray, uint cells, int flags);
			[Virtual] int PushString (CppInstancePtr @this, string @string);
			[Virtual] int PushStringEx (CppInstancePtr @this, string buffer, uint length, int sz_flags, int cp_flags);
			[Virtual] void Cancel (CppInstancePtr @this);
		}
		public unsafe struct _ICallable {
		}




		public ICallable (CppTypeInfo subClass)
		{
			__cxxi_LayoutClass ();
			subClass.AddBase (impl.TypeInfo);
		}

		public ICallable (CppInstancePtr native)
		{
			__cxxi_LayoutClass ();
			Native = native;
		}

		[OverrideNative ("PushCell")]
		public virtual int PushCell (int cell)
		{
			return impl.PushCell (Native, cell);
		}
		[OverrideNative ("PushCellByRef")]
		public virtual int PushCellByRef (ref int cell, int flags)
		{
			return impl.PushCellByRef (Native, ref cell, flags);
		}
		[OverrideNative ("PushFloat")]
		public virtual int PushFloat (float number)
		{
			return impl.PushFloat (Native, number);
		}
		[OverrideNative ("PushFloatByRef")]
		public virtual int PushFloatByRef (ref float number, int flags)
		{
			return impl.PushFloatByRef (Native, ref number, flags);
		}
		[OverrideNative ("PushArray")]
		public virtual int PushArray (ref int inarray, uint cells, int flags)
		{
			return impl.PushArray (Native, ref inarray, cells, flags);
		}
		[OverrideNative ("PushString")]
		public virtual int PushString (string @string)
		{
			return impl.PushString (Native, @string);
		}
		[OverrideNative ("PushStringEx")]
		public virtual int PushStringEx (string buffer, uint length, int sz_flags, int cp_flags)
		{
			return impl.PushStringEx (Native, buffer, length, sz_flags, cp_flags);
		}
		[OverrideNative ("Cancel")]
		public virtual void Cancel ()
		{
			impl.Cancel (Native);
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

