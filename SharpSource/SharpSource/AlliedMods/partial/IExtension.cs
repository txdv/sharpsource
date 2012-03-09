using System;
using System.Runtime.InteropServices;
using Mono.Cxxi;

namespace AlliedMods.SourceMod {
	unsafe public partial class IExtension : ICppObject {
		public virtual string Filename {
			get {
				return new string((sbyte *)GetFilename());
			}
		}
	}
}
