using System;
using System.Globalization;

namespace IMailAccess
{
    public static class Extensions
    {
        public static string ToJalaliFormatted(this DateTime dt)
        {
            PersianCalendar pc = new PersianCalendar();
            int year = pc.GetYear(dt);
            int month = pc.GetMonth(dt);
            int day = pc.GetDayOfMonth(dt);
            int hour = pc.GetHour(dt);
            int minute = pc.GetMinute(dt);
            DateTime Persian = new DateTime(year, month, day, hour, minute, 0);
            //string format = "yyyy/MM/dd";
            string format = "dd/MM/yyyy";
            return Persian.ToString(format);
        }
        public static DateTime ToMiladi(this DateTime dt)
        {
            PersianCalendar pc = new PersianCalendar();
            return pc.ToDateTime(dt.Year, dt.Month, dt.Day, dt.Hour, dt.Minute, 0, 0);
        }
    }
}
