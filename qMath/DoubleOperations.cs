using System;
using System.Collections.Generic;
using System.Text;

namespace qMath {
	public static class DoubleOperations {
		public static double AddWith(this double x, double y) => x + y;

		public static double SubtractFrom(this double x, double y) => y - x;

		public static double DivideBy(this double x, double y) => x / y;

		public static double ModulusBy(this double x, double y) => x % y;

		public static double MultiplyWith(this double x, double y) => x * y;

		public static double SquareRoot(this double x) => Math.Sqrt(x);

		public static double Round(this double x, int decimalPos = 0, MidpointRounding midpointRounding = MidpointRounding.AwayFromZero) => Math.Round(x, decimalPos, midpointRounding);

		public static double PowerOf(this double x, double raiseTo) => Math.Pow(x, raiseTo);

		public static double Absolute(this double x) => Math.Abs(x);
	}
}
