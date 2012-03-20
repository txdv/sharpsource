using System;
using AlliedMods;
using AlliedMods.SourceMod;
using AlliedMods.SourcePawn;

namespace TestSuite
{
	public class InteropTests : IExt
	{
		static int tests = 0;

		public InteropTests()
		{
			Core.ShareSys.AddNatives("test_addnative1", (IntPtr context, IntPtr arguments) => {
				tests++;
				return 1;
			});

			Core.ShareSys.AddNatives("test_addnative2", (IPluginContext context, int[] arguments) => {
				tests++;
				return 2;
			});


			Core.ShareSys.AddNatives(Core.Extension, typeof(InteropTests));
		}

		[SPMethod]
		public static void test_addnative0()
		{
			tests++;
		}

		[SPMethod("test_addnative3")]
		public static int test_addnative3()
		{
			tests++;
			return 3;
		}

		[SPMethod]
		public static int test_addnative4()
		{
			tests++;
			return 4;
		}

		[SPMethod]
		public static int test_addnative5(int argument)
		{
			tests++;
			if (argument != 42) {
				Console.WriteLine("failed test_addnative5");
			}
			return 5;
		}

		[SPMethod]
		public static int test_addnative6()
		{
			tests++;
			return 42;
		}

		[SPMethod]
		public static int test_addnative7(int i)
		{
			tests++;
			return i;
		}

		[SPMethod]
		public static void test_end(int count)
		{
			Console.WriteLine();
			Console.WriteLine("tests executed {0}/{1}", tests, count);
			Console.WriteLine();
		}

		[SPMethod]
		public static void test_callback1(Action<SPBuffer> callback, SPBuffer buffer, uint maxlength)
		{
			if (buffer.Get() != "HELLO WORLD") {
				Console.WriteLine("FAILED");
				return;
			}

			tests++;
			buffer.Set(buffer.Get().ToLower(), maxlength);
			callback(buffer);
		}

		[SPMethod]
		public static void test_callback2(Action<SPBuffer> callback, SPSizedBuffer buffer)
		{
			if (buffer.Get() != "hello world") {
				Console.WriteLine("FAILED");
				return;
			}

			tests++;
			buffer.Set("testing 1 3");
			callback(buffer);
		}
	}
}

