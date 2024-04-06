namespace DailyLeetCode.Test;

public class MinimumRemoveMakeValidParenthesesTests
{
    [Theory]
    [InlineData("lee(t(c)o)de)", "lee(t(c)o)de")]
    [InlineData("a)b(c)d", "ab(c)d")]
    [InlineData("))((", "")]
    public void Test(string input, string expected)
    {
        var actual = MinimumRemoveMakeValidParentheses.MinRemoveToMakeValid(input);
        Assert.Equal(expected, actual);
    }
}