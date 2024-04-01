using SlidingWindow.Medium;
namespace SlidingWindow.Test;

public class SlidingWindowMaximumTest
{
    [Theory]
    [InlineData(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, 3, new[] { 3, 4, 5, 6, 7, 8, 9, 10 })]
    [InlineData(new[] { 3, 3, 3, 3, 3, 3, 3, 3, 3, 3 }, 4, new[] { 3, 4, 5, 6, 7, 8, 9, 10 })]
    [InlineData(new[] { 10, 6, 9, -3, 23, -1, 34, 56, 67, -1, -4, -8, -2, 9, 10, 34, 67 }, 3, new[] { 10, 9, 23, 23, 34, 56, 67, 67, 67, -1, -2, 9, 10, 34, 67 })]
    public void AllShouldPass(int[] nums, int w, int[] expected)
    {
        var actual = SlidingWindowMaximum.FindMaxSlidingWindow(nums, w);
        Assert.Equal(expected, actual);
    }
}