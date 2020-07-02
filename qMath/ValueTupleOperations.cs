using System;
using System.Collections.Generic;
using System.Text;

namespace qMath {
	public static class ValueTupleOperations {
		public static int Sum(this ValueTuple<int, int> tuple) => tuple.Item1 + tuple.Item2;

		public static int Difference(this ValueTuple<int, int> tuple) => tuple.Item1 - tuple.Item2;

		public static int Product(this ValueTuple<int, int> tuple) => tuple.Item1 * tuple.Item2;

		public static int Quotient(this ValueTuple<int, int> tuple) => tuple.Item1 / tuple.Item2;

		public static int ModRemainder(this ValueTuple<int, int> tuple) => tuple.Item1 % tuple.Item2;


		public static int Sum(this ValueTuple<int, int, int> tuple) => tuple.Item1 + tuple.Item2 + tuple.Item3;

		public static int Difference(this ValueTuple<int, int, int> tuple) => (tuple.Item1 - tuple.Item2) - tuple.Item3;

		public static int Product(this ValueTuple<int, int, int> tuple) => (tuple.Item1 * tuple.Item2) * tuple.Item3;

		public static int Quotient(this ValueTuple<int, int, int> tuple) => (tuple.Item1 / tuple.Item2) / tuple.Item3;

		public static int ModRemainder(this ValueTuple<int, int, int> tuple) => (tuple.Item1 % tuple.Item2) % tuple.Item3;


		public static int Sum(this ValueTuple<int, int, int, int> tuple) => tuple.Item1 + tuple.Item2 + tuple.Item3 + tuple.Item4;

		public static int Difference(this ValueTuple<int, int, int, int> tuple) => (tuple.Item1 - tuple.Item2) - (tuple.Item3 - tuple.Item4);

		public static int Product(this ValueTuple<int, int, int, int> tuple) => (tuple.Item1 * tuple.Item2) * (tuple.Item3 * tuple.Item4);

		public static int Quotient(this ValueTuple<int, int, int, int> tuple) => (tuple.Item1 / tuple.Item2) / (tuple.Item3 / tuple.Item4);

		public static int ModRemainder(this ValueTuple<int, int, int, int> tuple) => (tuple.Item1 % tuple.Item2) % (tuple.Item3 % tuple.Item4);
	}
}
