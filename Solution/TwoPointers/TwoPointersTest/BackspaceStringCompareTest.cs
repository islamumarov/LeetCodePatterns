using src;
using Xunit;

namespace TwoPointersTest;

public class BackspaceStringCompareTest
{
    [Theory]
    [InlineData("ab#c","ab#c")]
    [InlineData("ab##", "c#d#")]
    public void AllShouldReturnTue(string s, string t)
    {
        var actual = BackspaceStringCompare.WithTwoPointers(s, t);
        Assert.True(actual);
    }
}