namespace DailyLeetCode.Test;

public class LengthOfLastWordTests
{
    [Theory]
    [InlineData("Hello World", 5)]
    [InlineData("   fly me   to   the moon  ", 4)]
    [InlineData("luffy is still joyboy", 6)]
    public void LengthOfLastWord_ShouldReturnLengthOfLastWord(string s, int expected)
    {
        var actual = LengthOfLastWordSolution.LengthOfLastWord(s);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void LengthOfLastWord_ShouldReturnZeroWhenStringIsEmpty()
    {
        var actual = LengthOfLastWordSolution.LengthOfLastWord("");
        Assert.Equal(0, actual);
    }

    [Fact]
    public void LengthOfLastWord_ShouldReturnZeroWhenStringIsWhiteSpace()
    {
        var actual = LengthOfLastWordSolution.LengthOfLastWord(" ");
        Assert.Equal(0, actual);
    }
}