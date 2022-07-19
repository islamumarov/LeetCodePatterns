using src;

namespace SubsetsTest;

public class PermutationTest
{
    [Theory]
    [InlineData("a1b2", new[] { "a1b2", "a1B2", "A1b2", "A1B2" })]
    [InlineData("3z4", new[] { "3z4", "3Z4" })]
    public void LetterCasePermutationTest(string str, string[] expected)
    {
        // Arrange
        var actual = LetterCase.LetterCasePermutation(str);
        //Assert
        Assert.Equal(expected.Length,actual.Count);
    }
}