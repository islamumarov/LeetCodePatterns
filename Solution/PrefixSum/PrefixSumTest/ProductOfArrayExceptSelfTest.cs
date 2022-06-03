using src;
using Xunit;

namespace PrefixSumTest;

public class ProductOfArrayExceptSelfTest
{
    [Theory]
    [InlineData(new int[] {1,2,3,4}, new int[] {24,12,8,6})]
    [InlineData(new int[]{-1,1,0,-3,3}, new int[] {0,0,9,0,0})]
    public void ProductExceptSelf(int[] nums, int[] expected)
    {
        var actual = ProductofArrayExceptSelf.ProductExceptSelf(nums);
        Assert.Equal(expected,actual);
    }
}