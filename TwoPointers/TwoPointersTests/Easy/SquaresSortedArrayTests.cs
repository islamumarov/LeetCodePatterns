using TwoPointers.Easy;
namespace TwoPointersTests.Easy;

public class SquaresSortedArrayTests
{
    [Theory]
    [InlineData(new[]
        {
            -4, -1, 0, 3, 10
        },
        new[]
        {
            0, 1, 9, 16, 100
        })]
    [InlineData(new[] {-7,-3,2,3,11}, new[] {4,9,9,49,121})]
    public void SortedSquares_AllShouldPass(int[] nums, int[] expected)
    {
        //Arrange
        var solution = new SquaresSortedArray();
        // Act
        var actual = solution.SortedSquares(nums);
        //Assert
        Assert.Equal(expected, actual);
    }
}
