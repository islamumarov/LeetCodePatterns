using src;
using Xunit;

namespace TwoPointersTest;

public class PairWithTargetSumTest
{
    [Theory]
    [InlineData(new[] {2,7,11,15}, 9, new[] {0,1})]
    [InlineData(new[] {2,3,4}, 6, new[] {1, 3})]
    public void ShouldPassAllTest(int[] arr, int target, int[] expected)
    {
        var actual = PairWithTargetSum.Search(arr, target);
        Assert.Equal(expected, actual);
    }
}