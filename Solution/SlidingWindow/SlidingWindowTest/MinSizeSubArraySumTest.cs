using SlidingWindow;
using Xunit;

namespace SlidingWindowTest;

public class MinSizeSubArraySumTest
{
    [Theory]
    [InlineData(new int[]{2, 1, 5, 2, 8}, 7,1)]
    public void findMinSubArrayTest( int[] arr,int S, int expected)
    {
        var actual = MinSizeSubArraySum.findMinSubArray(arr, S);
        Assert.Equal(expected,actual);
    }
}