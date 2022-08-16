using SharedKernel.Extensions;

namespace SharedKernelUnitTests.Extensions;

public class PersianDateExtensionsTest
{
    [Theory, MemberData(nameof(PersianNameOfWeekDayMapping))]
    public void GetPersianNameOfWeekDay_PassValidDayOfWeek_ReturnsValidPersianNameOfWeekDay(DayOfWeek dayOfWeek, string expectedDayOfWeekInPersian)
    {
        //act
        var persianNameOfWeekDay = PersianDateExtensions.GetPersianNameOfWeekDay(dayOfWeek);

        //assert
        Assert.Equal(expectedDayOfWeekInPersian, persianNameOfWeekDay);
    }

    public static IEnumerable<object[]> PersianNameOfWeekDayMapping =>
        new List<object[]>
        {
            new object[]
            {
                DayOfWeek.Saturday,
                "شنبه"
            },
            new object[]
            {
                DayOfWeek.Sunday,
                "یکشنبه"
            },
            new object[]
            {
                DayOfWeek.Monday,
                "دوشنبه"
            },
            new object[]
            {
                DayOfWeek.Tuesday,
                "سه شنبه"
            },
            new object[]
            {
                DayOfWeek.Wednesday,
                "چهارشنبه"
            },
            new object[]
            {
                DayOfWeek.Thursday,
                "پنج شنبه"
            },
            new object[]
            {
                DayOfWeek.Friday,
                "جمعه"
            },
        };

    [Theory, MemberData(nameof(ValidDateTimesAndCorrespondingPersianDatesSeperatedByDash))]
    public void GetShortPersianDateWithDash_PassValidDateTime_ReturnsValidPersianDateSeparatedWithDash(DateTime date, string expectedPersianDate)
    {
        //act
        var persianDate = PersianDateExtensions.GetShortPersianDateWithDash(date);

        //assert
        Assert.Equal(persianDate, expectedPersianDate);
    }

    public static IEnumerable<object[]> ValidDateTimesAndCorrespondingPersianDatesSeperatedByDash =>
    new List<object[]>
    {
            new object[]
            {
                DateTime.Parse("2025-03-20"), // Leap Day in Jalali Calendar
                "1403-12-30"
            },
            new object[]
            {
                DateTime.Parse("2006-06-04"),
                "1385-3-14"
            },
            new object[]
            {
                DateTime.Parse("2020-12-25"),
                "1399-10-5"
            },
            new object[]
            {
                DateTime.Parse("1876-07-06"),
                "1255-4-16"
            },
            new object[]
            {
                DateTime.Parse("1977-03-09"),
                "1355-12-18"
            },
            new object[]
            {
                DateTime.Parse("1589-09-03"),
                "968-6-12"
            },
    };


}