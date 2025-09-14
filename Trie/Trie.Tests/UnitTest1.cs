namespace Trie.Tests;

public class UnitTest1
{
    [Theory]
    [InlineData(new int[] {1,10,100 }, new int[] { 1000 }, 3)]
    public void AllShouldPass(int[] arr1, int[] arr2, int expected)
    {
        var actual = TrieImplementation.LongestCommonPrefix(arr1, arr2);
        
        Assert.Equal(expected, actual);
    }
}