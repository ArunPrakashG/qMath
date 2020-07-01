using System;
using System.Collections.Generic;
using System.Text;

namespace qMath {
	public static class TimeSpanOperations {
		public static TimeSpan AsHoursSpan(this double x) => TimeSpan.FromHours(x);

		public static TimeSpan AsDaysSpan(this double x) => TimeSpan.FromDays(x);

		public static TimeSpan AsMinutesSpan(this double x) => TimeSpan.FromMinutes(x);

		public static DateTime AsDateTime(this TimeSpan span) => new DateTime(span.Ticks);

		public static DateTime AsDateTime(this TimeSpan span, DateTimeKind kind) => new DateTime(span.Ticks, kind);
	}
}
