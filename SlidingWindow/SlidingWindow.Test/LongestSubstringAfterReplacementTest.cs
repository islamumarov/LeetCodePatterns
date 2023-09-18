using SlidingWindow.Hard;
namespace SlidingWindow.Test;

public class LongestSubstringAfterReplacementTest
{
    [Theory]
    [InlineData("aabccbb", 2, 5)]
    [InlineData("abbcb", 1, 4)]
    public void AllShouldPass(string str, int k, int expected)
    {
        var actual = LongestSubstringAfterReplacement.FindLength(str, k);
        Assert.Equal(expected, actual);
    }
}