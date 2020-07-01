using System;

namespace qMath {
	public static class IntegerOperations {
		public static int AddWith(this int x, int y) => x + y;

		public static int SubtractFrom(this int x, int y) => y - x;

		public static int DivideBy(this int x, int y) => x / y;

		public static int ModulusBy(this int x, int y) => x % y;

		public static int MultiplyWith(this int x, int y) => x * y;

		public static int Absolute(this int x) => Math.Abs(x);

		public static int AsRandomMaxNext(this int x) => Internals.Random.Next(x);

		public static bool IsWithin(this int x, int y, int z) => x >= y && x <= z;

		public static bool IsIntegerMax(this int x) => x == int.MaxValue;

		public static bool IsIntegerMin(this int x) => x == int.MinValue;

		public static bool AsBool(this int x) => x >= 1;
	}
}
