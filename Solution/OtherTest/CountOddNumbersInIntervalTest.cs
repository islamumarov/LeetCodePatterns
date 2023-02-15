using AnyLeetcode;
using Xunit;

namespace OtherTest;

public class CountOddNumbersInIntervalTest
{

    [Theory]
    [InlineData(14,17,2)]
    [InlineData(13,18,3)]
    [InlineData(3,7,3)]
    [InlineData(8,10, 1)]
    public void AllShouldPass(int low, int high, int expected)
    {
        var actual = CountOddNumbersInInterval.CountOdds(low, high);
        Assert.Equal(expected, actual);
    }
}