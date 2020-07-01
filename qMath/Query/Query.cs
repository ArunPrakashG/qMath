using System;
using System.Collections.Generic;
using System.Text;

namespace qMath.Query {
	public sealed class Query<T, U> {
		private readonly QueryBuilder<T, U> QueryBuilder;

		public Query(QueryBuilder<T, U> queryBuilder) {
			QueryBuilder = queryBuilder;
		}

		internal enum Operations {
			Addition,
			Subtract,
			Multiplication,
			Division,
			Modulus
		}
	}
}
