namespace DailyLeetCode.Test;

public class ValidParenthesisStringTests
{
    [Theory]
    [InlineData("()", true)]
    [InlineData("()*", true)]
    [InlineData("(*)", true)]
    [InlineData("(*))", true)]
    [InlineData("((*)", true)]
    [InlineData("((*))", true)]
    [InlineData("((*)))", true)]
    [InlineData("((*)))", true)]
    [InlineData("((*)))", true)]
    public void Test(string s, bool expected)
    {
        var actual = ValidParenthesisString.CheckValidString(s);
        Assert.Equal(expected, actual);
    }
}