using SlidingWindow;
using Xunit;

namespace SlidingWindowTest;

public class NoRepeatSubstringTest
{
    [Theory]
    [InlineData("aabccbb",3)]
    [InlineData("abbbb",2)]
    [InlineData("bbbbbbb",1)]
    public void FindLengthTest(string str, int expected)
    {
        var actual = NoRepeatSubstring.FindLength(str);
        Assert.Equal(expected,actual);
    }
}