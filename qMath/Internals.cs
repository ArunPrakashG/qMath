using System;

namespace qMath {
	internal static class Internals {

		/// <summary>
		/// Single, static instance of <see cref="System.Random"/> insures we don't get repeated values. (to some degree)
		/// </summary>
		internal static readonly Random Random = new Random();
	}
}
