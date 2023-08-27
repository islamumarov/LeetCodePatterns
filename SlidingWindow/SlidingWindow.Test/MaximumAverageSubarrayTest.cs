using SlidingWindow.Easy;

namespace SlidingWindow.Test;

public class MaximumAverageSubarrayTest
{
    [Theory]
    [InlineData(new[] { 1, 12, -5, -6, 50, 3 }, 4, 12.75000)]
    [InlineData(new[] { 0, 4, 0, 3, 2 }, 1, 4.00000)]
    public void AllShouldPass(int[] nums, int k, double expected)
    {
        var actual = MaximumAverageSubarray.FindMaxAverage(nums, k);
        Assert.Equal(expected, actual);
    }
}