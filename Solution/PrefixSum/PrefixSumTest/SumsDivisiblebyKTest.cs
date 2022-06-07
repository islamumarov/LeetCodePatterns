using Xunit;

namespace PrefixSumTest;

public class SumsDivisiblebyKTest
{
    [Theory]
    [InlineData(new int[] {4,5,0,-2,-3,1},5,7)]
    public void SubarraysDivByK(int[] nums,int k, int expected)
    {
        var actual = SumsDivisiblebyK.SubarraysDivByK(nums, k);
        Assert.Equal(expected,actual);
    }
}