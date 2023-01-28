using SlidingWindow;
using Xunit;

namespace SlidingWindowTest;

public class PermutationInStringTest
{
    [Theory]
    [InlineData("ab", "eidboaoo")]
    [InlineData("adc","dcda")]
    public void CheckInclusionTest(string s1, string s2)
    {
        var actual = PermutationInString.CheckInclusion(s1, s2);
    }
}