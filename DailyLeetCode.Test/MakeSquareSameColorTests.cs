namespace DailyLeetCode.Test;

public class MakeSquareSameColorTests
{
    [Theory]
    [MemberData(nameof(TestData))]
    public void CanMakeSquare_AllShouldPass(char[][] grid, bool expected)
    {
        var actual = MakeSquareSameColor.CanMakeSquare(grid);
        Assert.Equal(expected, actual);
    }



    public static IEnumerable<object[]> TestData()
    {
        yield return
        [
            new char[][] { new char[] { 'B', 'W', 'B' }, new char[] { 'B', 'W', 'W' }, new char[] { 'B', 'W', 'B' } }
            , true
        ];
        yield return
        [
            new char[][] { new char[] { 'B', 'W', 'B' }, new char[] { 'W', 'B', 'W' }, new char[] { 'B', 'W', 'B' } },
            false
        ];

        yield return
        [
            new char[][] { new char[] { 'B', 'B', 'B' }, new char[] { 'B', 'W', 'W' }, new char[] { 'W', 'B', 'B' } },
            true
        ];
    }
}
