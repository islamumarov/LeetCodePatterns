using TwoPointers.Easy;
namespace TwoPointersTests.Easy;

public class TwoSumInSortedArrayTests
{
    [Theory]
    [InlineData(new[] { 1, 2, 3, 4, 6 }, 6, new[] { 1, 3 })]
    [InlineData(new[] { 2, 5, 9, 11 }, 11, new[] { 0, 2 })]
    public void FindTwoSum_AllShouldPass(int[] nums, int target, int[] expected)
    {
        //Assert
        var solution = new TwoSumInSortedArray();

        //Act
        var actual = solution.FindTwoSum(nums, target);

        Assert.Equal(expected, actual);
    }
}