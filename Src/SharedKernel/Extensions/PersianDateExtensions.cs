using System.Globalization;

namespace SharedKernel.Extensions {
	public static class PersianDateExtensions {
        private static string GetPersianNameOfWeekDay(DayOfWeek day)
        {
            return day switch
            {
                DayOfWeek.Saturday => "شنبه",
                DayOfWeek.Sunday => "یکشنبه",
                DayOfWeek.Monday => "دوشنبه",
                DayOfWeek.Tuesday => "سه شنبه",
                DayOfWeek.Wednesday => "چهارشنبه",
                DayOfWeek.Thursday => "پنج شنبه",
                DayOfWeek.Friday => "جمعه",
                _ => ""
            };
        }
        private static string GetPersianNameOfMonth(int month)
        {
            switch (month)
            {
                case 1:
                    return "فروردین";
                case 2:
                    return "اردیبهشت";
                case 3:
                    return "خرداد";
                case 4:
                    return "تیر";
                case 5:
                    return "مرداد";
                case 6:
                    return "شهریور";
                case 7:
                    return "مهر";
                case 8:
                    return "آبان";
                case 9:
                    return "آذر";
                case 10:
                    return "دی";
                case 11:
                    return "بهمن";
                case 12:
                    return "اسفند";
            }
            return "";
        }
        private static string GetPersianNameOfDay(int day)
        {
            switch (day)
            {
                case 1:
                    return "یکم";
                case 2:
                    return "دوم";
                case 3:
                    return "سوم";
                case 4:
                    return "چهارم";
                case 5:
                    return "پنجم";
                case 6:
                    return "ششم";
                case 7:
                    return "هفتم";
                case 8:
                    return "هشتم";
                case 9:
                    return "نهم";
                case 10:
                    return "دهم";
                case 11:
                    return "یازدهم";
                case 12:
                    return "دوازدهم";
                case 13:
                    return "سیزدهم";
                case 14:
                    return "چهاردهم";
                case 15:
                    return "پانزدهم";
                case 16:
                    return "شانزدهم";
                case 17:
                    return "هفدهم";
                case 18:
                    return "هجدهم";
                case 19:
                    return "نوزدهم";
                case 20:
                    return "بیستم";
                case 21:
                    return "بیست و یکم";
                case 22:
                    return "بیست و دوم";
                case 23:
                    return "بیست و سوم";
                case 24:
                    return "بیست و چهارم";
                case 25:
                    return "بیست و پنجم";
                case 26:
                    return "بیست و ششم";
                case 27:
                    return "بیست و هفتم";
                case 28:
                    return "بیست و هشتم";
                case 29:
                    return "بیست و نهم";
                case 30:
                    return "سی ام";
                case 31:
                    return "سی و یکم";
            }
            return "";
        }

        public static string GetShortPersianDate(this DateTime dateTime)
        {
            return new PersianCalendar().GetYear(dateTime) + "/" +
                   new PersianCalendar().GetMonth(dateTime) + "/" +
                   new PersianCalendar().GetDayOfMonth(dateTime);
        }
        public static string GetShortPersianDateTime(this DateTime dateTime)
        {
            return $"{dateTime.GetShortPersianDate()} - {new PersianCalendar().GetHour(dateTime)}:{new PersianCalendar().GetMinute(dateTime)}";
        }
        public static string GetLongPersianDate(this DateTime dateTime)
        {
            return GetPersianNameOfWeekDay(new PersianCalendar().GetDayOfWeek(dateTime)) + "، " +
                   GetPersianNameOfDay(new PersianCalendar().GetDayOfMonth(dateTime)) + "  " +
                   GetPersianNameOfMonth(new PersianCalendar().GetMonth(dateTime)) + "  " +
                   new PersianCalendar().GetYear(dateTime).ToString(CultureInfo.InvariantCulture).ToPersianNumbers();
        }
        public static string GetLongPersianDateTime(this DateTime dateTime)
        {
            return $"{dateTime.GetLongPersianDate()} - {new PersianCalendar().GetHour(dateTime).ToString(CultureInfo.InvariantCulture).ToPersianNumbers()}:{new PersianCalendar().GetMinute(dateTime).ToString(CultureInfo.InvariantCulture).ToPersianNumbers()}";
        }
        /// <summary>
        /// Converts Persian Date in Year/Month/Day format to corresponding gregorian date
        /// </summary>
        /// <param name="persianDate">Persian Date in Year/Month/Day format</param>
        /// <returns></returns>
        public static DateTime GetGregorianDate(this string persianDate)
        {
            var strDate = persianDate.Split('/');
            int y, m, d;

            y = int.Parse(strDate[0]);
            m = int.Parse(strDate[1]);
            d = int.Parse(strDate[2]);

            var jC = new PersianCalendar();
            return jC.ToDateTime(y, m, d, 0, 0, 0, 0);
        }
    }
}
