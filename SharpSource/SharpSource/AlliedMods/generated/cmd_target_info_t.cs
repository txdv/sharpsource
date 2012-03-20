// -------------------------------------------------------------------------
//  Managed wrapper for cmd_target_info_t
//  Generated from bindings.xml on 03/09/2012 13:42:17
//
//  This file was auto generated. Do not edit.
// -------------------------------------------------------------------------

using System;
using Mono.Cxxi;

namespace AlliedMods.SourceMod {
	public partial class cmd_target_info_t : ICppObject {

		private static readonly Icmd_target_info_t impl = Libs.AlliedMods.GetClass<Icmd_target_info_t,_cmd_target_info_t,cmd_target_info_t> ("cmd_target_info_t");
		public CppInstancePtr Native { get; protected set; }

		[MangleAs ("struct SourceMod::cmd_target_info_t")]
		public partial interface Icmd_target_info_t : ICppClassOverridable<cmd_target_info_t> {
			CppField<string> pattern { get; }
			CppField<int> admin { get; }
			CppField<IntPtr> targets { get; }
			CppField<int> max_targets { get; }
			CppField<int> flags { get; }
			CppField<string> target_name { get; }
			CppField<uint> target_name_maxlength { get; }
			CppField<int> target_name_style { get; }
			CppField<int> reason { get; }
			CppField<uint> num_targets { get; }
		}
		public unsafe struct _cmd_target_info_t {
			public string pattern;
			public int admin;
			public IntPtr targets;
			public int max_targets;
			public int flags;
			public string target_name;
			public uint target_name_maxlength;
			public int target_name_style;
			public int reason;
			public uint num_targets;
		}

		public string pattern {
			get {
				return impl.pattern [Native];
			}
			set {
				impl.pattern [Native] = value;
			}
		}
		public int admin {
			get {
				return impl.admin [Native];
			}
			set {
				impl.admin [Native] = value;
			}
		}
		public int targets {
			get {
				return (int)impl.targets [Native];
			}
			set {
				impl.targets [Native] = (IntPtr) value;
			}
		}
		public int max_targets {
			get {
				return impl.max_targets [Native];
			}
			set {
				impl.max_targets [Native] = value;
			}
		}
		public int flags {
			get {
				return impl.flags [Native];
			}
			set {
				impl.flags [Native] = value;
			}
		}
		public string target_name {
			get {
				return impl.target_name [Native];
			}
			set {
				impl.target_name [Native] = value;
			}
		}
		public uint target_name_maxlength {
			get {
				return impl.target_name_maxlength [Native];
			}
			set {
				impl.target_name_maxlength [Native] = value;
			}
		}
		public int target_name_style {
			get {
				return impl.target_name_style [Native];
			}
			set {
				impl.target_name_style [Native] = value;
			}
		}
		public int reason {
			get {
				return impl.reason [Native];
			}
			set {
				impl.reason [Native] = value;
			}
		}
		public uint num_targets {
			get {
				return impl.num_targets [Native];
			}
			set {
				impl.num_targets [Native] = value;
			}
		}



		public cmd_target_info_t (CppTypeInfo subClass)
		{
			__cxxi_LayoutClass ();
			subClass.AddBase (impl.TypeInfo);
		}

		public cmd_target_info_t (CppInstancePtr native)
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

