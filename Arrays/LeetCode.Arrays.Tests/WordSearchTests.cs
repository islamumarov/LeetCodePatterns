namespace LeetCode.Arrays.Tests;

public class WordSearchTests
{
    public static IEnumerable<object[]> WordSearchData =>
    [
        [
            new char[][]
            {
                ['A', 'B', 'C', 'E'],
                ['S', 'F', 'C', 'S'],
                ['A', 'D', 'E', 'E']
            },
            "ABCCED",
            true
        ],
        [
            new char[][]
            {
                ['A', 'B', 'C', 'E'],
                ['S', 'F', 'C', 'S'],
                ['A', 'D', 'E', 'E']
            },
            "SEE",
            true
        ],
        [
            new char[][]
            {
                ['A', 'B', 'C', 'E'],
                ['S', 'F', 'C', 'S'],
                ['A', 'D', 'E', 'E']
            },
            "ABCB",
            false
        ],
        [
            new char[][]
            {
                ['A', 'B', 'C'],
                ['D', 'E', 'F'],
                ['G', 'H', 'I']
            },
            "AEI",
            false
        ]
    ];


    [Theory]
    [MemberData(nameof(WordSearchData))]
    public void WordSearch_AllShouldPass(char[][] board, string word, bool expected)
    {
        var result = WordSearch.Exist(board, word);
        Assert.Equal(expected, result);
    }

}
