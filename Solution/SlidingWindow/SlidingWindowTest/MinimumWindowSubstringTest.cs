using SlidingWindow;
using Xunit;

namespace SlidingWindowTest;

public class MinimumWindowSubstringTest
{
    [Theory]
    [InlineData("ADOBECODEBANC", "ABC", "BANC")]
    [InlineData("a", "a", "a")]
    [InlineData("a", "aa", "")]
    public void ShouldPassAllTheTests(string s, string t, string expected)
    {
        var actual = MinimumWindowSubstring.MinWindow(s, t);
        Assert.Equal(expected, actual);
    }
}