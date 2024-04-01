using SlidingWindow.Hard;
namespace SlidingWindow.Test;

public class ContainsDuplicate3Test
{
    [Theory]
    [InlineData(new[] { 1, 2, 3, 1 }, 3, 0, true)]
    [InlineData(new[] { 1,5,9,1,5,9 }, 2, 3, false)]
    public void AllShouldPass(int[] nums, int k, int t, bool expected)
    {
        var actual = ContainsDuplicate3.ContainsNearbyAlmostDuplicate(nums, k, t);
        Assert.Equal(expected, actual);
    }
}