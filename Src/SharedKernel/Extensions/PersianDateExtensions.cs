using System.Globalization;

namespace SharedKernel.Extensions {
	public static class PersianDateExtensions {
        public static string GetPersianNameOfWeekDay(DayOfWeek day)
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

        private static string GetPersianNameOfMonth(int mount)
        {
            switch (mount)
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
        public static string GetShortPersianDateWithDash(this DateTime dateTime)
        {
            return (new PersianCalendar().GetYear(dateTime) + "-" +
                    new PersianCalendar().GetMonth(dateTime) + "-" +
                    new PersianCalendar().GetDayOfMonth(dateTime) + "  -  " +
                    new PersianCalendar().GetHour(dateTime) + "-" +
                    new PersianCalendar().GetMinute(dateTime));

        }

        private static string GetShortPersianDate(this DateTime dateTime)
        {
            var persianDate = new PersianCalendar().GetYear(dateTime) + "/";

            // اگر ماه کوچکتر از 10 باشد یک صفر به آن اضافه می کند
            if (Convert.ToInt32(new PersianCalendar().GetMonth(dateTime)) > 9)
            {
                persianDate += new PersianCalendar().GetMonth(dateTime) + "/";
            }
            else
            {
                persianDate += "0" + new PersianCalendar().GetMonth(dateTime) + "/";
            }
            // اگر روز کوچکتر از 10 باشد یک صفر به آن اضافه می کند
            if (Convert.ToInt32(new PersianCalendar().GetDayOfMonth(dateTime)) > 9)
            {
                persianDate += new PersianCalendar().GetDayOfMonth(dateTime);
            }
            else
            {
                persianDate += "0" + new PersianCalendar().GetDayOfMonth(dateTime) ;
            }
            return persianDate;

        }
        public static string GetPersianDateMonth(this DateTime dateTime)
        {
            return Convert.ToInt32(new PersianCalendar().GetMonth(dateTime)) > 9
                ? new PersianCalendar().GetMonth(dateTime).ToString()
                : "0" + new PersianCalendar().GetMonth(dateTime);
        }
        public static int GetPersianMonth(this DateTime dateTime)
        {
            return new PersianCalendar().GetMonth(dateTime);
        }
        public static int GetPersianYear(this DateTime dateTime)
        {
            return new PersianCalendar().GetYear(dateTime);
        }

        private static string GetShortPersianDateTime(this DateTime dateTime)
        {
            return (new PersianCalendar().GetYear(dateTime) + "/" +
                    new PersianCalendar().GetMonth(dateTime) + "/" +
                    new PersianCalendar().GetDayOfMonth(dateTime) + " - " +
                    new PersianCalendar().GetHour(dateTime) + ":" +
                    new PersianCalendar().GetMinute(dateTime));

        }
        public static string GetShortPersianDateTime(this DateTime? dateTime)
        {
            return !dateTime.HasValue ? string.Empty : GetShortPersianDateTime(dateTime.Value);
        }
        public static string GetShortPersianDate(this DateTime? dateTime)
        {
            return !dateTime.HasValue ? string.Empty : GetShortPersianDate(dateTime.Value);

        }
        public static string GetLongPersianDate(this DateTime dateTime)
        {
            return (GetPersianNameOfWeekDay(new PersianCalendar().GetDayOfWeek(dateTime)) + "، " +
                    GetPersianNameOfDay(new PersianCalendar().GetDayOfMonth(dateTime)) + "  " +
                    GetPersianNameOfMonth(new PersianCalendar().GetMonth(dateTime)) + "  " +
                    (new PersianCalendar().GetYear(dateTime).ToString(CultureInfo.InvariantCulture).ToPersianNumbers()));
        }
        public static string GetLongPersianDateTime(this DateTime dateTime)
        {
            return (GetPersianNameOfWeekDay(new PersianCalendar().GetDayOfWeek(dateTime)) + "، " +
                    GetPersianNameOfDay(new PersianCalendar().GetDayOfMonth(dateTime)) + "  " +
                    GetPersianNameOfMonth(new PersianCalendar().GetMonth(dateTime)) + "  " +
                    (new PersianCalendar().GetYear(dateTime).ToString(CultureInfo.InvariantCulture).ToPersianNumbers())) +
                    " - " +
                    new PersianCalendar().GetHour(dateTime).ToString(CultureInfo.InvariantCulture).ToPersianNumbers()
                    + ":" +
                    new PersianCalendar().GetMinute(dateTime).ToString(CultureInfo.InvariantCulture).ToPersianNumbers();
        }

        private static DateTime GetGregorianDate(this string persianDate)
        {
            var strDate = persianDate.Split('/');
            int y, m, d;
            if (strDate[0].Length == 4)
            {
                y = int.Parse(strDate[0]);
                m = int.Parse(strDate[1]);
                d = int.Parse(strDate[2]);
            }
            else
            {
                y = int.Parse(strDate[2]);
                m = int.Parse(strDate[0]);
                d = int.Parse(strDate[1]);
            }
            var jC = new PersianCalendar();
            return jC.ToDateTime(y, m, d, 0, 0, 0, 0);
        }
        public static DateTime GetGregorianDateFromPersianNumber(this string persianDate)
        {
            persianDate = persianDate.ToEnglishNumbers();
            var x = persianDate.Split('/').ToArray();
            return x[0].Length == 4 ? $"{x[0]}/{x[1]}/{x[2]}".GetGregorianDate() : $"{x[2]}/{x[1]}/{x[0]}".GetGregorianDate();
        }
        public static DateTime GetGregorianDateTime(this string persianDateTime)
        {
            var strDate = persianDateTime.Split(' ')[0].Split('/');
            var strTime = persianDateTime.Split(' ')[1].Split(':');
            int y, m, d, hh, mm;
            if (strDate[0].Length == 4)
            {
                y = int.Parse(strDate[0]);
                m = int.Parse(strDate[1]);
                d = int.Parse(strDate[2]);
                hh = int.Parse(strTime[0]);
                mm = int.Parse(strTime[1]);
            }
            else
            {
                y = int.Parse(strDate[2]);
                m = int.Parse(strDate[1]);
                d = int.Parse(strDate[0]);
                hh = int.Parse(strTime[0]);
                mm = int.Parse(strTime[1]);
            }
            var jC = new PersianCalendar();
            return jC.ToDateTime(y, m, d, hh, mm, 0, 0);
        }
    }
}
