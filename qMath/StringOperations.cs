using System;

namespace qMath {
	public static class StringOperations {
		public static int AsInteger(this string stringValue) {
			try {
				return Convert.ToInt32(stringValue);
			}
			catch (Exception) {
				return -1;
			}
		}

		public static double AsDouble(this string stringValue) {
			try {
				return Convert.ToDouble(stringValue);
			}
			catch (Exception) {
				return -1.0;
			}
		}

		public static float AsFloat(this string stringValue) {
			try {
				return Convert.ToSingle(stringValue);
			}
			catch (Exception) {
				return -1;
			}
		}

		public static long AsLong(this string stringValue) {
			try {
				return Convert.ToInt64(stringValue);
			}
			catch (Exception) {
				return -1;
			}
		}

		public static bool AsBool(this string stringValue) => stringValue.Equals("true", StringComparison.OrdinalIgnoreCase);

		public static bool AsBool(this string stringValue, StringComparison comparison) => stringValue.Equals("true", comparison);
	}
}
