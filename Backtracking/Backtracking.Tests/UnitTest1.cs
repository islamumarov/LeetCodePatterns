namespace Backtracking.Tests;

public class SubsetsTests
{
    [Theory]
    [MemberData(nameof(TestData))]
    public void Test1(int[] nums, IList<IList<int>> expected)
    {
        var actual = Subsets78.Subsets(nums);
        Assert.Equal(expected, actual);
    }

    public static IEnumerable<object[]> TestData()
    {
        yield return
        [
            new int[] { 1, 2, 3 },
            new List<IList<int>>
            {
                new List<int> { },
                new List<int> { 1 },
                new List<int> { 2 },
                new List<int> { 3 },
                new List<int> { 1, 2 },
                new List<int> { 1, 3 },
                new List<int> { 2, 3 },
                new List<int> { 1, 2, 3 }
            }
        ];

        yield return new object[]
        {
            new int[] { 0 },
            new List<IList<int>>
            {
                new List<int> { },
                new List<int> { 0 }
            }
        };
    }
}