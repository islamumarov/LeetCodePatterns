namespace DFS.Tests;

public class ConcatenatedWords472Tests
{
    [Theory]
    [InlineData(
        new string[]
        {
            "cat",
            "cats",
            "catsdogcats",
            "dog",
            "dogcatsdog",
            "hippopotamuses",
            "rat",
            "ratcatdogcat",
        },
        new string[] { "catsdogcats", "dogcatsdog", "ratcatdogcat" }
    )]
    public void Test1(string[] words, string[] expected)
    {
        var actual = ConcatenatedWords472.FindAllConcatenatedWordsInADict(words);

        Assert.Equal(expected, actual);
    }
}