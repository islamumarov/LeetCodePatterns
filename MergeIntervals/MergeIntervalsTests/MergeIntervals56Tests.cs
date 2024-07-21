using MergeIntervals;
namespace MergeIntervalsTests;

public class MergeIntervals56Tests
{
    [Fact]
    public void Merge_AllTestShouldPass()
    {
        var expected = new int[][]
        {
            new[] { 0, 4 },
        };
        var intervals = new int[][]
        {
            new[] { 1, 4 },
            new[] { 0, 4 }
        };
        var actual = MergeIntervals56.Merge(intervals);

        Assert.Equal(expected, actual);
    }
}
