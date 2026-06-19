namespace Stack.Queue.Tests;

public class DailyTemperatureTests
{
    [Theory]
    [MemberData(nameof(GetTestData))]
    public void AllShouldPass(int[] temperatures, int[] expected)
    {
        var actual = DailyTemperatures.DailyTemperaturesSol(temperatures);
        Assert.Equal(expected, actual);
    }

    public static IEnumerable<object[]> GetTestData()
    {
        yield return new object[] { new int[] { 73, 74, 75, 71, 69, 72, 76, 73 }, new int[] { 1, 1, 4, 2, 1, 1, 0, 0 } };
    }
}