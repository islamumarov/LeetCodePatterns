using AnyLeetcode;
using Xunit;

namespace OtherTest;

public class AddTwoBinaryStringsTest
{
    [Theory]
    [InlineData("1010", "1011", "10101")]
    [InlineData("11", "1", "100")]
    [InlineData("0", "0", "0")]
    public void AllShouldPass(string a, string b, string expected)
    {
        var actual = AddTwoBinaryStrings.AddBinary(a, b);
        Assert.Equal(expected, actual);
    }
}