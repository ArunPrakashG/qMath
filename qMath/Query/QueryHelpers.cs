using System;
using static qMath.Query.QueryBuilder;

namespace qMath.Query {
	public static class QueryHelpers {
		public static QueryBuilder GenerateQuery(this ValueTuple<int, int> intialElementTuple, InitialOperation initialOperation)
			=> new QueryBuilder(intialElementTuple.Item1, intialElementTuple.Item2, initialOperation);

		public static QueryBuilder GenerateQuery(this Tuple<int, int> intialElementTuple, InitialOperation initialOperation)
			=> new QueryBuilder(intialElementTuple.Item1, intialElementTuple.Item2, initialOperation);
	}
}
