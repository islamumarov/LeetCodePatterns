using src;
using Xunit;

namespace TopKNumbersTest;

public class KLargestNumbersTest
{
    [Theory]
   // [InlineData(new int[] {3,2,3,1,2,4,5,5,6}, 4,4)]
    [InlineData(new int[] {3,2,1,5,6,4},2,5)]
    public void findKLargestNumbersTest(int[] nums, int k, int expected)
    {
        var actual = KLargestNumbers.findKLargestNumbers(nums, k);
        Assert.Equal(expected, actual);
    }

}