using System;

namespace qMath {
	public static class IntegerOperations {
		public static int AddWith(this int x, int y) => x + y;

		public static int SubtractFrom(this int x, int y) => y - x;

		public static int DivideBy(this int x, int y) => x / y;

		public static int ModulusBy(this int x, int y) => x % y;

		public static int MultiplyWith(this int x, int y) => x * y;

		public static int Absolute(this int x) => Math.Abs(x);
	}
}
