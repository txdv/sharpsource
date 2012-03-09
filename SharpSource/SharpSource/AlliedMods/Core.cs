using System;
using System.IO;
using System.Reflection;
using System.Runtime;
using System.Runtime.InteropServices;
using AlliedMods;
using AlliedMods.SourcePawn;
using AlliedMods.SourceMod;
using Mono.Cxxi;
using System.Linq;

namespace AlliedMods
{
	public interface IExt
	{
	}

	public static class Core
	{
		public static string HomePath { get; private set; }
		public static string ExtensionsPath { get; private set; }

		public static ISourceMod SourceMod { get; private set; }
		public static IShareSys ShareSys { get; private set; }
		public static IExtension Extension { get; private set; }

		public static void Init(IntPtr smutilsptr, IntPtr sharesysptr, IntPtr myself)
		{
			Console.WriteLine (Directory.GetCurrentDirectory());
			HomePath = Path.Combine(Directory.GetCurrentDirectory(), "cstrike/addons/sharpsource");
			ExtensionsPath = Path.Combine(HomePath, "extensions");
			SourceMod = new ISourceMod(new CppInstancePtr(smutilsptr));
			ShareSys = new IShareSys(new CppInstancePtr(sharesysptr));
			Extension = new IExtension(new CppInstancePtr(myself));
			Init();
		}

		public static void Init()
		{
			try {
				LoadExtensions();
			} catch (Exception e) {
				Console.WriteLine("Failed to load extensions: {0}", e.Message);
			}

			SharpSource.Core.Init();
		}

		private static IExt GetInstance(Assembly asm)
		{
			var type = asm.GetTypes().Where(e => e.GetInterface("IExt") != null);
			if (type.Count() > 0) {
				var f = type.First();
				return f.GetConstructor(new Type[] { }).Invoke(new object[] { }) as IExt;
			}
			return null;
		}

		private static void LoadExtensions()
		{
			var extensions = Directory.GetFiles(ExtensionsPath).Where(m => m.EndsWith(".dll"));
			foreach (var extpath in extensions) {
				GetInstance(Assembly.LoadFrom(extpath));
			}
		}
	}
}
