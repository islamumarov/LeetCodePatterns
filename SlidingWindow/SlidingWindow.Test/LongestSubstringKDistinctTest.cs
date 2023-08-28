using SlidingWindow.Medium;

namespace SlidingWindow.Test;

public class LongestSubstringKDistinctTest
{
    [Theory]
    [InlineData("araaci", 2, 4)]
    [InlineData("araaci", 1, 2)]
    public void AllShouldPass(string str, int k, int expected)
    {
        var actual = LongestSubstringKDistinct.FindLength(str, k);
        Assert.Equal(expected, actual);
    }
}