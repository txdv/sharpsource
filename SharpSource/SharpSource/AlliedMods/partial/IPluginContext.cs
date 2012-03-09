using System;
using System.Runtime.InteropServices;
using Mono.Cxxi;

namespace AlliedMods.SourcePawn {
	public partial class IPluginContext : ICppObject {
		unsafe public int LocalToString (int localAddr, out string str)
		{
			IntPtr addr;
			int ret = LocalToString(localAddr, out addr);
			str = new string((sbyte *)addr);
			return ret;
		}

		public int Execute2 (SourcePawn.IPluginFunction function, int[] @params)
		{
			int result;
			return Execute2 (function, @params, out result);
		}

		public int Execute2 (SourcePawn.IPluginFunction function, int[] @params, out int result)
		{
			var handle = GCHandle.Alloc(@params, GCHandleType.Pinned);
			var ret = Execute2(function, handle.AddrOfPinnedObject(), (uint)@params.Length, out result);
			handle.Free();
			return ret;
		}
	}
}

