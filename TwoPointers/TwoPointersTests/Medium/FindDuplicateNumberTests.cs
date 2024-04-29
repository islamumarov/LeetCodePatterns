using TwoPointers.Medium;
namespace TwoPointersTests.Medium;

public class FindDuplicateNumberTests
{
    [Theory]
    [InlineData(new[] {1,3,4,2,2}, 2)]
    [InlineData(new[] {3,1,3,4,2}, 3)]
    public void FindDuplicate_AllShouldPass(int[] nums, int expected)
    {
        //Arrange
        // Act
        var actual = FindDuplicateNumber.FindDuplicate(nums);
        Assert.Equal(expected, actual);
    }
}
