// -------------------------------------------------------------------------
//  Managed wrapper for sp_nativeinfo_s
//  Generated from bindings.xml on 02/28/2012 15:56:54
//
//  This file was auto generated. Do not edit.
// -------------------------------------------------------------------------

using System;
using System.Text;
using System.Runtime.InteropServices;
using Mono.Cxxi;

namespace AlliedMods {
	unsafe public struct sp_nativeinfo_s : IDisposable
	{
		static sp_nativeinfo_s()
		{
			Sentinel = new sp_nativeinfo_s();
			Sentinel.name = (sbyte *)0;
			Sentinel.function = IntPtr.Zero;
		}
		public static sp_nativeinfo_s Sentinel;

		public sbyte *name;
		public IntPtr function;

		public sp_nativeinfo_s(sbyte *name, IntPtr function)
		{
			this.name = name;
			this.function = function;
		}

		public sp_nativeinfo_s(string name, IntPtr function)
		{
			var bytes = Encoding.ASCII.GetBytes(name);
			var b = new byte[bytes.Length + 1];
			bytes.CopyTo(b, 0);

			var buffer = Marshal.AllocHGlobal(b.Length);
			Marshal.Copy(b, 0, buffer, b.Length);
			this.name = (sbyte *)buffer;
			this.function = function;
		}

		#region IDisposable implementation
		public void Dispose()
		{
			Marshal.FreeHGlobal((IntPtr)name);
		}
		#endregion
	}
	/*
	public partial class sp_nativeinfo_s : ICppObject {

		private static readonly Isp_nativeinfo_s impl = Libs.AlliedMods.GetClass<Isp_nativeinfo_s,_sp_nativeinfo_s,sp_nativeinfo_s> ("sp_nativeinfo_s");
		public CppInstancePtr Native { get; protected set; }

		[MangleAs ("struct sp_nativeinfo_s")]
		public partial interface Isp_nativeinfo_s : ICppClassOverridable<sp_nativeinfo_s> {
			CppField<string> name { get; }
			CppField<IntPtr> func { get; }
		}
		public unsafe struct _sp_nativeinfo_s {
			public string name;
			public IntPtr func;
		}

		public string name {
			get {
				return impl.name [Native];
			}
			set {
				impl.name [Native] = value;
			}
		}
		public IntPtr func {
			get {
				return impl.func [Native];
			}
			set {
				impl.func [Native] = value;
			}
		}



		public sp_nativeinfo_s (CppTypeInfo subClass)
		{
			__cxxi_LayoutClass ();
			subClass.AddBase (impl.TypeInfo);
		}

		public sp_nativeinfo_s (CppInstancePtr native)
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
	*/
}

