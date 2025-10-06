using TwoPointers;

namespace LeetCodePatterns.Tests.TwoPointers;

public class MostWaterTests
{
    [Theory]
    [InlineData(new[]{1,8,6,2,5,4,8,3,7}, 49)]
    [InlineData(new []{1,1}, 1)]
    public void AllShouldPass_MaxArea(int[] heights, int expected)
    {
        var actual = MostWater.MaxArea(heights);
        Assert.Equal(expected, actual);
    }
}
