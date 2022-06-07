using SlidingWindow;
using Xunit;

namespace SlidingWindowTest;

public class PermutationInStringTest
{
    [Theory]
    [InlineData("ab", "eidboaoo", true)]
    [InlineData("adc","dcda",true)]
    public void CheckInclusionTest(string s1, string s2, bool expected)
    {
        var actual = PermutationInString.CheckInclusion(s1, s2);
    }
}