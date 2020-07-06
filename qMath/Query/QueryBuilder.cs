using System;

namespace qMath.Query {
	public struct QueryBuilder : ICloneable {
		private readonly int BaseElementX;
		private readonly int BaseElementY;
		private readonly InitialOperation Operation;
		private int CurrentValue;
		public int OperationsDone { get; private set; }

		public QueryBuilder(int x, int y, InitialOperation initialOperation) {
			BaseElementX = x;
			BaseElementY = y;
			CurrentValue = 0;
			OperationsDone = 0;
			Operation = initialOperation;

			CurrentValue = SetInitialValue(x, y, initialOperation);
		}

		private int SetInitialValue(int x, int y, InitialOperation initialOperation) {
			try {
				switch (initialOperation) {
					case InitialOperation.Addition:
						return x.AddWith(y);
					case InitialOperation.Subtraction:
						return y.SubtractFrom(x);
					case InitialOperation.Multiplication:
						return x.MultiplyWith(y);
					case InitialOperation.Division:
						return x.DivideBy(y);
					case InitialOperation.Modulus:
						return x.ModulusBy(y);
				}
			}
			finally {
				OperationsDone++;
			}		

			return -1;
		}

		public object Clone() => new QueryBuilder(BaseElementX, BaseElementY, Operation);

		public int Build() => CurrentValue;

		public QueryBuilder Sum() {
			CurrentValue = BaseElementX + BaseElementY;
			OperationsDone++;
			return this;
		}

		public QueryBuilder Product() {
			CurrentValue = BaseElementX * BaseElementY;
			OperationsDone++;
			return this;
		}

		public QueryBuilder RaiseTo(int power) {
			CurrentValue = (int) Math.Pow(CurrentValue, power);
			OperationsDone++;
			return this;
		}

		public QueryBuilder Difference() {
			CurrentValue = BaseElementX - BaseElementY;
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

		public enum InitialOperation {
			Addition,
			Subtraction,
			Multiplication,
			Division,
			Modulus
		}
	}
}
