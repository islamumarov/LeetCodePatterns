using SlidingWindow.Easy;

namespace SlidingWindow.Test;

public class MinSizeSubArraySumTest
{
    [Theory]
    [InlineData(7, new[] { 2, 1, 5, 2, 3, 2 }, 2)]
    [InlineData(7, new[] { 2, 1, 5, 2, 8 }, 1)]
    [InlineData(8, new[] { 3, 4, 1, 1, 6 }, 3)]
    [InlineData(11, new[] { 1, 1, 1, 1, 1, 1, 1, 1 }, 0)]
    public void AllShouldPass(int s, int[] arr, int expected)
    {
        var actual = MinSizeSubArraySum.FindMinSubArray(s, arr);
        Assert.Equal(expected, actual);
    }
}