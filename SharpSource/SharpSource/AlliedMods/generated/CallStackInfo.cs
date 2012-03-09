// -------------------------------------------------------------------------
//  Managed wrapper for CallStackInfo
//  Generated from bindings.xml on 02/28/2012 15:56:54
//
//  This file was auto generated. Do not edit.
// -------------------------------------------------------------------------

using System;
using Mono.Cxxi;

namespace AlliedMods.SourcePawn {
	public partial class CallStackInfo : ICppObject {

		private static readonly ICallStackInfo impl = Libs.AlliedMods.GetClass<ICallStackInfo,_CallStackInfo,CallStackInfo> ("CallStackInfo");
		public CppInstancePtr Native { get; protected set; }

		[MangleAs ("struct SourcePawn::CallStackInfo")]
		public partial interface ICallStackInfo : ICppClassOverridable<CallStackInfo> {
			CppField<string> filename { get; }
			CppField<uint> line { get; }
			CppField<string> function { get; }
		}
		public unsafe struct _CallStackInfo {
			public string filename;
			public uint line;
			public string function;
		}

		public string filename {
			get {
				return impl.filename [Native];
			}
			set {
				impl.filename [Native] = value;
			}
		}
		public uint line {
			get {
				return impl.line [Native];
			}
			set {
				impl.line [Native] = value;
			}
		}
		public string function {
			get {
				return impl.function [Native];
			}
			set {
				impl.function [Native] = value;
			}
		}



		public CallStackInfo (CppTypeInfo subClass)
		{
			__cxxi_LayoutClass ();
			subClass.AddBase (impl.TypeInfo);
		}

		public CallStackInfo (CppInstancePtr native)
		{
			__cxxi_LayoutClass ();
			Native = native;
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

