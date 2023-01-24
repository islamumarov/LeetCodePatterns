using SlidingWindow;
using Xunit;

namespace SlidingWindowTest;

public class ContainsDuplicate2Test
{
    [Theory]
    [InlineData(new []{1,2,3,1}, 3, 0)]
    [InlineData(new []{1,2,1,1},1,0)]
    public void ShouldBeAllTrue(int[] nums, int k, int t)
    {
        var actual = ContainsDuplicate2.ContainsNearbyAlmostDuplicate(nums, k, t);
        Assert.True(actual);
    }

    [Theory]
    [InlineData(new int[] { 1, 5, 9, 1, 5, 9 },  2,  3)]
    public void ShouldBeAllFalse(int[] nums, int k, int t)
    {
        var actual = ContainsDuplicate2.ContainsNearbyAlmostDuplicate(nums, k, t);
        Assert.False(actual);
    }
}