using SlidingWindow;
using Xunit;

namespace SlidingWindowTest;

public class CharacterReplacementTest
{
    /// <summary>
    /// <see cref="CharacterReplacement"/>
    /// </summary>
    [Theory]
    [InlineData("aabccbb",2,5)]
    public void FindLengthTest(string str, int K, int expected)
    {
        var actual = CharacterReplacement.FindLength(str, K);
        Assert.Equal(expected,actual);
    }
}