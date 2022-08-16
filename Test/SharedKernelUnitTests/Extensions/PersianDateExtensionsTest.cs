using SharedKernel.Extensions;

namespace SharedKernelUnitTests.Extensions;

public class PersianDateExtensionsTest
{
    [Theory, MemberData(nameof(PersianNameOfWeekDayMapping))]
    public async Task GetPersianNameOfWeekDay_PassValidDate_ReturnsValidPersianNameOfWeekDay(DayOfWeek dayOfWeek, string expectedDayOfWeekInPersian)
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
}