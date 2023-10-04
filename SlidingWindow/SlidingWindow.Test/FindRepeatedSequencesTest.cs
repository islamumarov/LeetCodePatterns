using SlidingWindow.Medium;
namespace SlidingWindow.Test;

public class FindRepeatedSequencesTest
{
    [Theory]
    [InlineData("AAAAACCCCCAAAAACCCCCC", 8, new[] { "AAAAACCC", "AAAACCCC", "AAACCCCC" })]
    [InlineData("AAAAAACCCCCCCAAAAAAAACCCCCCCTG", 10, new[] { "AAAAAACCCC", "AAAAACCCCC", "AAAACCCCCC", "AAACCCCCCC" })]
    [InlineData("TTTTTCCCCCCCTTTTTTCCCCCCCTTTTTTT", 10, new[] { "CCCCCCCTTT", "CCCCCCTTTT", "CCCCCTTTTT", "CCCCTTTTTT", "TCCCCCCCTT", "TTCCCCCCCT", "TTTCCCCCCC", "TTTTCCCCCC", "TTTTTCCCCC" })]
    [InlineData("GGGGGGGGGGGGGGGGGGGGGGGGG", 9, new[] { "GGGGGGGGG" })]
    [InlineData("ATATATATATATATAT", 6, new[] { "ATATAT", "TATATA" })]
    public void AllShouldPass(string s, int k, string[] expected)
    {
        var actual = FindRepeatedSequences.FindRepeatedSequencesOfDNA(s, k).ToArray();
        foreach (var item in actual)
        {
            Assert.Contains(item, expected);
        }
    }
}