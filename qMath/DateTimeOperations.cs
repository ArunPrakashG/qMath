using System;

namespace qMath {
	public static class DateTimeOperations {
		public static double DifferenceInDays(this DateTime initial, DateTime final) => (initial - final).TotalDays;

		public static double DifferenceInHours(this DateTime initial, DateTime final) => (initial - final).TotalHours;

		public static double DifferenceInMinutes(this DateTime initial, DateTime final) => (initial - final).TotalMinutes;

		public static TimeSpan SubtractFrom(this DateTime x, DateTime y) => y - x;

		public static DateTime AddSpan(this DateTime x, TimeSpan span) => x.Add(span);

		public static DateTime AddTicks(this DateTime x, long ticks) => x.AddTicks(ticks);

		public static DateTime AddTime(this DateTime x, DateTime y) => x.AddTicks(y.Ticks);

		public static bool IsSameYear(this DateTime x, DateTime y) => x.Year == y.Year;

		public static bool IsSameDay(this DateTime x, DateTime y) => x.Day == y.Day;

		public static bool IsSameMonth(this DateTime x, DateTime y) => (x.Month == y.Month) && x.IsSameYear(y);

		public static bool IsEqualTo(this DateTime x, DateTime y) => x.IsSameYear(y) && x.IsSameMonth(y) && x.IsSameDay(y);

		public static bool IsBefore(this DateTime x, DateTime y) => x < y;

		public static bool IsAfter(this DateTime x, DateTime y) => x > y;

		public static bool IsFriday(this DateTime x) => x.DayOfWeek == DayOfWeek.Friday;

		public static bool Is(this DateTime x, DayOfWeek day) => x.DayOfWeek == day;

		public static bool IsSaturday(this DateTime x) => x.DayOfWeek == DayOfWeek.Saturday;

		public static bool IsSunday(this DateTime x) => x.DayOfWeek == DayOfWeek.Sunday;

		public static bool IsToday(this DateTime x) {
			var today = DateTime.Now;
			return x.IsSameDay(today) && x.IsSameMonth(today);
		}

		public static bool IsYesterday(this DateTime x) {
			var yesterday = DateTime.Now.AddDays(-1);
			return x.IsSameDay(yesterday) && x.IsSameMonth(yesterday);
		}

		public static bool IsBefore(this DateTime x, double days) => x.IsBefore(days.AsDaysSpan().AsDateTime());

		public static bool IsAfter(this DateTime x, double days) => x.IsAfter(days.AsDaysSpan().AsDateTime());

		public static DateTime NextFriday(this DateTime x) => x.AddDays(((int) DayOfWeek.Friday - (int) x.DayOfWeek + 7) % 7);

		public static DateTime Next(this DateTime x, DayOfWeek day) => x.AddDays(((int) day - (int) x.DayOfWeek + 7) % 7);

		public static DateTime Previous(this DateTime x, DayOfWeek day) => x.AddDays(- (((int) day - (int) x.DayOfWeek + 7) % 7));

		public static DateTime PreviousFriday(this DateTime x) => x.AddDays(-(((int) DayOfWeek.Friday - (int) x.DayOfWeek + 7) % 7));
	}
}
