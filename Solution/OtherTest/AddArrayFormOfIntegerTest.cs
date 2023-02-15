using AnyLeetcode;
using Xunit;

namespace OtherTest;

public class AddArrayFormOfIntegerTest
{
    [Theory]
    [InlineData(new int[]{1,2,0,0}, 34, new int[]{1,2,3,4})]
    [InlineData(new [] {9,9,9,9,9,9,9,9,9,9},1,new[] {1,0,0,0,0,0,0,0,0,0,0})]
    [InlineData(new []{1,2,6,3,0,7,1,7,1,9,7,5,6,6,4,4,0,0,6,3},516, new[]{1,2,6,3,0,7,1,7,1,9,7,5,6,6,4,4,0,5,7,9})]
    public void ShouldPassAllTests(int[] num, int k, int[] expected)
    {
        var actual = AddArrayFormOfInteger.AddToArrayForm2(num, k);
        Assert.Equal(expected, actual);
    }
}