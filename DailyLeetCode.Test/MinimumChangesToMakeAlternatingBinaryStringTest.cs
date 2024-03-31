namespace DailyLeetCode.Test;

public class MinimumChangesToMakeAlternatingBinaryStringTest
{
    [Theory]
    [InlineData("0100", 1)]
    [InlineData("10", 0)]
    [InlineData("1111", 2)]
    [InlineData("10010100", 3)]
    public void All_Should_Pass(string s, int expected)
    {
        var actual = MinimumChangesToMakeAlternatingBinaryString.MinOperations(s);
        Assert.Equal(expected, actual);
    }
}