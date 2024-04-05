namespace DailyLeetCode.Test;

public class MakeTheStringGreatTests
{
    [Theory]
    [InlineData("leEeetcode", "leetcode")]
    [InlineData("abBAcC", "")]
    [InlineData("s", "s")]
    public void MakeTheStringGreat_ShouldReturnCorrectResult(string input, string expected)
    {
        var result = MakeTheStringGreat.MakeGood(input);
        Assert.Equal(expected, result);
    } 
}