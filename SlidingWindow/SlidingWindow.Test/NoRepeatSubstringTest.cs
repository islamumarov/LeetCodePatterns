using SlidingWindow.Hard;
namespace SlidingWindow.Test;

public class NoRepeatSubstringTest
{

    [Theory]
    [InlineData("aabccbb", 3)]
    [InlineData("abbbb", 2)]
    [InlineData("abccde", 3)]
    [InlineData("abcabcbb", 3)]
    [InlineData("bbbbb", 1)]
    [InlineData("pwwkew", 3)]
    public void AllShouldPass(string str, int expected)
    {
        var actual = NoRepeatSubstring.FindLength(str);
        Assert.Equal(expected, actual);
    }
}