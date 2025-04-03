namespace DailyLeetCode.Test;

public class OneStringSwapTest
{

    [Theory]
    [InlineData("bank", "kanb", true)]
    [InlineData("aa", "ac", false)]
    public void AreAlmostEqual_AllShouldPass(string a, string b, bool expected)
    {
        var actual = OneStringSwap.AreAlmostEqual(a, b);
        Assert.Equal(expected, actual);
    }
}