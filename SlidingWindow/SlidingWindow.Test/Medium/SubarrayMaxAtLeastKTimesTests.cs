using SlidingWindow.Medium;

namespace SlidingWindow.Test.Medium;

public class SubarrayMaxAtLeastKTimesTests
{
    [Theory]
    [InlineData(new int[] { 1, 3, 2, 3, 3 }, 2, 6)]
    public void CountSubarrays_AllShouldPass(int[] nums, int k, int expected)
    {
        // Arrange
        var solver = new SubarrayMaxAtLeastKTimes();

        // Act
        var actual = solver.CountSubarrays(nums, k);

        //Assert
        Assert.Equal(expected, actual);
    }
}
