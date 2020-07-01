using System;
using System.Collections.Generic;
using System.Text;

namespace qMath.Query {
	public sealed class QueryBuilder<T, U> : ICloneable {
		internal readonly int[] Elements;
		internal readonly T FirstElement;
		internal readonly U SecondElement;
		internal readonly int Size;

		public QueryBuilder(T firstElement, U secondElement, int size) {
			Size = size;
			Elements = Size > 0 ? new int[Size] : new int[] { };
			FirstElement = firstElement;
			SecondElement = secondElement;
		}

		public object Clone() => new QueryBuilder<T, U>(FirstElement, SecondElement, Size);

		//TODO: Add query methods to build up...
	}
}
