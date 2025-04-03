namespace Heap.Tests;

public class TopKFrequentElementsTests
{
    [Theory]
    [InlineData(new int[] {1,1,1,2,2,3}, 2, new int[] {1,2})]
    public void AllShouldPass_TopKFrequent(int[] nums, int k, int[] expected)
    {
        var actual = TopKFrequentElements.TopKFrequent(nums, k);
        Assert.Equal(expected, actual);
    }
}