using System;
using System.Collections.Generic;
using System.Text;

namespace qMath.Query {
	public static class QueryHelpers {
		public static QueryBuilder<T, U> GenerateQuery<T, U>(this ValueTuple<T, U> intialElementTuple, int size = -1)
			=> new QueryBuilder<T, U>(intialElementTuple.Item1, intialElementTuple.Item2, size);

		public static QueryBuilder<T, U> GenerateQuery<T, U>(this Tuple<T, U> intialElementTuple, int size = -1)
			=> new QueryBuilder<T, U>(intialElementTuple.Item1, intialElementTuple.Item2, size);
	}
}
