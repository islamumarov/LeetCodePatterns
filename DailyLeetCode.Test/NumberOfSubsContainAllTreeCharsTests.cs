namespace DailyLeetCode.Test;

public class NumberOfSubsContainAllTreeCharsTests
{
    
    [Theory]
    [InlineData("abcabc", 10)]
    public void NumberOfSubstrings_AllShouldPass(string s, int expected)
    {
        var actual = NumberOfSubsContainAllTreeChars.NumberOfSubstrings(s);
        Assert.Equal(expected, actual);
    }
}