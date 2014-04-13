using System;

namespace WSRsmooz
{
    public static class DateTimeExtensions
    {
        // use: DateTime dt = DateTime.Now.StartOfWeek(DayOfWeek.Monday);
        public static DateTime StartOfWeek(this DateTime dt, DayOfWeek startOfWeek)
        {
            int diff = dt.DayOfWeek - startOfWeek;
            if (diff < 0)
                diff += 7;
            return dt.AddDays(-1 * diff).Date;
        }

        // use: DateTime dt = DateTime.Now.Next(DayOfWeek.Sunday);
        public static DateTime Next(this DateTime from, DayOfWeek dayOfWeek)
        {
            int start = (int)from.DayOfWeek;
            int target = (int)dayOfWeek;
            if (target <= start)
                target += 7;
            return from.AddDays(target - start);
        }
    }
}
