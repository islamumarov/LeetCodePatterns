using src;
using Xunit;

namespace PrefixSumTest;

public class MaxSubarrayTest
{
    [Theory]
    [InlineData(new int[] {-2,1,-3,4,-1,2,1,-5,4}, 6)]
    [InlineData(new int[] {-1,-2},-1)]
    [InlineData(new int[] {5,4,-1,7,8}, 23)]
    public void FindLargestSumTest(int[] nums, int expected)
    {
        var actual = MaxSubarray.FindLargestSum(nums);
        Assert.Equal(expected,actual);  
    }
    
}