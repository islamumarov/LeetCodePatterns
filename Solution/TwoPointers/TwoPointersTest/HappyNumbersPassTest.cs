using src;
using Xunit;

namespace TwoPointersTest;

public class HappyNumbersPassTest
{
    [Theory]
    [InlineData(19)]
    [InlineData(23)]
    public void AllTestsShouldPassWithTrue(int num)
    {
        var actual = HappyNumber.FindHappyNumber(num);
        Assert.True(actual);
    }

    [Theory]
    [InlineData(2)]
    [InlineData(12)]
    public void AllTestShouldPassWithFalse(int num)
    {
        var actual = HappyNumber.FindHappyNumber(num);
        Assert.False(actual);
    }
}