using SharedKernel.Extensions;

namespace SharedKernelUnitTests.Extensions;

public class PersianDateExtensionsTest
{
    [Theory, MemberData(nameof(ValidDateTimesAndCorrespondingPersianDates))]
    public void GetShortPersianDate_PassValidDateTime_ReturnsValidPersianDate(DateTime date, string expectedPersianDate)
    {
        //act
        var shortPersianDate = PersianDateExtensions.GetShortPersianDate(date);

        //assert
        Assert.Equal(shortPersianDate, expectedPersianDate);
    }
    public static IEnumerable<object[]> ValidDateTimesAndCorrespondingPersianDates =>
        new List<object[]>
        {
            new object[]
            {
                DateTime.Parse("2025-03-20"), // Leap Day in Jalali Calendar
                "1403/12/30"
            },
            new object[]
            {
                DateTime.Parse("2006-06-04"),
                "1385/3/14"
            },
            new object[]
            {
                DateTime.Parse("2020-12-25"),
                "1399/10/5"
            },
            new object[]
            {
                DateTime.Parse("1876-07-06"),
                "1255/4/16"
            },
            new object[]
            {
                DateTime.Parse("1977-03-09"),
                "1355/12/18"
            },
            new object[]
            {
                DateTime.Parse("1589-09-03"),
                "968/6/12"
            },
        };

    [Theory, MemberData(nameof(ValidDateTimesAndCorrespondingShortPersianDateTimes))]
    public void GetShortPersianDateTime_PassValidDateTime_ReturnsValidPersianDateTime(DateTime date, string expectedPersianDate)
    {
        //act
        var shortPersianDateTime = PersianDateExtensions.GetShortPersianDateTime(date);

        //assert
        Assert.Equal(shortPersianDateTime, expectedPersianDate);
    }
    public static IEnumerable<object[]> ValidDateTimesAndCorrespondingShortPersianDateTimes =>
        new List<object[]>
        {
            new object[]
            {
                DateTime.Parse("2025-03-20 15:22"), // Leap Day in Jalali Calendar
                "1403/12/30 - 15:22"
            },
            new object[]
            {
                DateTime.Parse("2006-06-04 00:22"),
                "1385/3/14 - 0:22"
            },
            new object[]
            {
                DateTime.Parse("2020-12-25 08:41"),
                "1399/10/5 - 8:41"
            },
            new object[]
            {
                DateTime.Parse("1876-07-06 03:41"),
                "1255/4/16 - 3:41"
            },
            new object[]
            {
                DateTime.Parse("1977-03-09 16:55"),
                "1355/12/18 - 16:55"
            },
            new object[]
            {
                DateTime.Parse("1589-09-03 10:14"),
                "968/6/12 - 10:14"
            },
            new object[]
            {
                DateTime.Parse("1589-09-03"),
                "968/6/12 - 0:0"
            }
        };

    [Theory, MemberData(nameof(ValidDateTimesAndCorrespondingLongPersianDateTimes))]
    public void GetLongPersianDateTime_PassValidDateTime_ReturnsValidLongPersianDateTime(DateTime date, string expectedPersianDate)
    {
        //act
        var longPersianDateTime = PersianDateExtensions.GetLongPersianDateTime(date);

        //assert
        Assert.Equal(longPersianDateTime, expectedPersianDate);
    }
    public static IEnumerable<object[]> ValidDateTimesAndCorrespondingLongPersianDateTimes =>
    new List<object[]>
    {
        new object[]
        {
            DateTime.Parse("2025-03-20 15:22"), // Leap Day in Jalali Calendar
            "پنج شنبه، سی ام  اسفند  ۱۴۰۳ - ۱۵:۲۲"
        },
        new object[]
        {
            DateTime.Parse("2020-12-25 08:41"),
            "جمعه، پنجم  دی  ۱۳۹۹ - ۸:۴۱"
        },
        new object[]
        {
            DateTime.Parse("2006-06-04 00:22"),
            "یکشنبه، چهاردهم  خرداد  ۱۳۸۵ - ۰:۲۲"
        },
        new object[]
        {
            DateTime.Parse("1876-07-06 03:41"),
            "پنج شنبه، شانزدهم  تیر  ۱۲۵۵ - ۳:۴۱"
        },
        new object[]
        {
            DateTime.Parse("1977-03-09 16:55"),
            "چهارشنبه، هجدهم  اسفند  ۱۳۵۵ - ۱۶:۵۵"
        },
        new object[]
        {
            DateTime.Parse("1589-09-03 10:14"),
            "یکشنبه، دوازدهم  شهریور  ۹۶۸ - ۱۰:۱۴"
        },
        new object[]
        {
            DateTime.Parse("1589-09-03"),
            "یکشنبه، دوازدهم  شهریور  ۹۶۸ - ۰:۰"
        }
    };

    [Theory, MemberData(nameof(ValidDateTimesAndCorrespondingLongPersianDate))]
    public void GetLongPersianDate_PassValidDateTime_ReturnsValidLongPersianDate(DateTime date, string expectedPersianDate)
    {
        //act
        var longPersianDate = PersianDateExtensions.GetLongPersianDate(date);

        //assert
        Assert.Equal(longPersianDate, expectedPersianDate);
    }
    public static IEnumerable<object[]> ValidDateTimesAndCorrespondingLongPersianDate =>
    new List<object[]>
    {
        new object[]
        {
            DateTime.Parse("2025-03-20 15:22"), // Leap Day in Jalali Calendar
            "پنج شنبه، سی ام  اسفند  ۱۴۰۳"
        },
        new object[]
        {
            DateTime.Parse("2020-12-25 08:41"),
            "جمعه، پنجم  دی  ۱۳۹۹"
        },
        new object[]
        {
            DateTime.Parse("2006-06-04 00:22"),
            "یکشنبه، چهاردهم  خرداد  ۱۳۸۵"
        },
        new object[]
        {
            DateTime.Parse("1876-07-06 03:41"),
            "پنج شنبه، شانزدهم  تیر  ۱۲۵۵"
        },
        new object[]
        {
            DateTime.Parse("1977-03-09 16:55"),
            "چهارشنبه، هجدهم  اسفند  ۱۳۵۵"
        },
        new object[]
        {
            DateTime.Parse("1589-09-03 10:14"),
            "یکشنبه، دوازدهم  شهریور  ۹۶۸"
        },
        new object[]
        {
            DateTime.Parse("1589-09-03"),
            "یکشنبه، دوازدهم  شهریور  ۹۶۸"
        }
    };

    [Theory, MemberData(nameof(ValidPersianAndCorrespondingGregorianDates))]
    public void GetGregorianDate_PassValidDateTime_ReturnsValidDateTime(string persianDate, DateTime expectedDate)
    {
        //act
        var gregorianDate = PersianDateExtensions.GetGregorianDate(persianDate);

        //assert
        Assert.Equal(gregorianDate, expectedDate);
    }
    public static IEnumerable<object[]> ValidPersianAndCorrespondingGregorianDates =>
    new List<object[]>
    {
        new object[]
        {
            "1403/12/30", // Leap Day in Jalali Calendar
            DateTime.Parse("2025-03-20")
        },
        new object[]
        {
            "1385/3/1",
            DateTime.Parse("2006-05-22")
        },
        new object[]
        {
            "1399/10/05",
            DateTime.Parse("2020-12-25")
        },
        new object[]
        {
            "1255/04/01",
            DateTime.Parse("1876-06-21")
        },
        new object[]
        {
            "1355/12/18",
            DateTime.Parse("1977-03-09")
        },
        new object[]
        {
            "968/6/12",
            DateTime.Parse("1589-09-03")
        },
        new object[]
        {
            "1377/08/03",
            DateTime.Parse("1998-10-25")
        }
    };
}