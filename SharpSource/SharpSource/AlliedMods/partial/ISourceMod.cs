using System;
using System.Text;
using System.Runtime.InteropServices;
using Mono.Cxxi;

namespace AlliedMods.SourceMod {
	unsafe public partial class ISourceMod : ICppObject {
		public string GetPath(SourceMod.PathType type, string format, int size)
		{
			IntPtr ptr = Marshal.AllocHGlobal(size);
			BuildPath(type, ptr, (uint)size, format);
			string ret = new string((sbyte *)ptr);
			Marshal.FreeHGlobal(ptr);
			return ret;
		}

		public string GetPath(SourceMod.PathType type, int size)
		{
			return GetPath(type, "", size);
		}

		public string GetPath(SourceMod.PathType type)
		{
			return GetPath(type, 1024);
		}

		public string GamePath {
			get {
				return GetPath (PathType.Path_Game);
			}
		}

		public string SMPath{
			get {
				return GetPath(PathType.Path_SM);
			}
		}

		public string SMPathRelative {
			get {
				return GetPath(PathType.Path_SM_Rel);
			}
		}
	}
}