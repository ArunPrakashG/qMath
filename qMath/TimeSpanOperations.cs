using System;

namespace qMath {
	public static class TimeSpanOperations {
		public static DateTime AsDateTime(this TimeSpan span) => new DateTime(span.Ticks);

		public static DateTime AsDateTime(this TimeSpan span, DateTimeKind kind) => new DateTime(span.Ticks, kind);
	}
}
