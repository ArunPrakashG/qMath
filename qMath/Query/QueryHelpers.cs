using System;
using System.Collections.Generic;
using System.Text;

namespace qMath.Query {
	public static class QueryHelpers {
		public static QueryBuilder GenerateQuery(this ValueTuple<int, int> intialElementTuple)
			=> new QueryBuilder(intialElementTuple.Item1, intialElementTuple.Item2);

		public static QueryBuilder GenerateQuery(this Tuple<int, int> intialElementTuple)
			=> new QueryBuilder(intialElementTuple.Item1, intialElementTuple.Item2);
	}
}
