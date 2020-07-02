using System;
using System.Collections.Generic;
using System.Text;

namespace qMath.Query {
	public struct QueryBuilder : ICloneable {
		private readonly int FirstElement;
		private readonly int SecondElement;
		private int CurrentValue;
		public int OperationsDone { get; private set; }

		public QueryBuilder(int firstElement, int secondElement) {			
			FirstElement = firstElement;
			SecondElement = secondElement;
			CurrentValue = 0;
			OperationsDone = 0;
		}

		public object Clone() => new QueryBuilder(FirstElement, SecondElement);

		public int Build() => CurrentValue;

		public QueryBuilder Sum() {
			CurrentValue = FirstElement + SecondElement;
			OperationsDone++;
			return this;
		}

		public QueryBuilder Product() {
			CurrentValue = FirstElement * SecondElement;
			OperationsDone++;
			return this;
		}

		public QueryBuilder RaiseTo(int power) {
			CurrentValue = (int) Math.Pow(CurrentValue, power);
			OperationsDone++;
			return this;
		}

		public QueryBuilder Difference() {
			CurrentValue = FirstElement - SecondElement;
			OperationsDone++;
			return this;
		}

		public QueryBuilder Subtract(int x) {
			CurrentValue -= x;
			OperationsDone++;
			return this;
		}

		public QueryBuilder Add(int x) {
			CurrentValue += x;
			OperationsDone++;
			return this;
		}

		public QueryBuilder Multiply(int x) {
			CurrentValue *= x;
			OperationsDone++;
			return this;
		}

		public QueryBuilder Divide(int x) {
			CurrentValue /= x;
			OperationsDone++;
			return this;
		}

		public QueryBuilder Mod(int x) {
			CurrentValue %= x;
			OperationsDone++;
			return this;
		}

		//TODO: Add query methods to build up...
	}
}
