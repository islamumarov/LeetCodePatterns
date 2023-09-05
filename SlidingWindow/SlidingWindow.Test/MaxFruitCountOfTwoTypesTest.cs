using SlidingWindow.Medium;
namespace SlidingWindow.Test;

public class MaxFruitCountOfTwoTypesTest
{
    [Theory]
    [InlineData(new[] { 'A', 'B', 'C', 'A', 'C' }, 3)]
    [InlineData(new[] { 'A', 'B', 'C', 'B', 'B', 'C' }, 5)]
    [InlineData(new[] { '1', '2', '3', '2', '2' }, 4)]
    [InlineData(new[] { '3', '3', '3', '1', '2', '1', '1', '2', '3', '3', '4' }, 5)]
    public void AllShouldPass(char[] arr, int expected)
    {
        var actual = MaxFruitCountOfTwoTypes.FindLength(arr);
        Assert.Equal(expected, actual);
    }
}