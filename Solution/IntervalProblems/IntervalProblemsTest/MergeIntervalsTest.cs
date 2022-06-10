using src;
using Xunit;

namespace IntervalProblemsTest;

public class MergeIntervalsTest
{
    [Fact]
    public void Merge()
    {
        var interval1 = new int[][] { new int[]{ 1, 3 }, new int[]{ 2, 6 },new int[] { 8, 10 },new int[] { 15, 18 } };
        var actual = MergeIntervals.Merge(interval1);
        int[][] expected = new int[][]
        {
            new int[] { 1, 6 },
            new int[] { 8, 10 },
            new int[] { 15, 18 }
        };
        Assert.Equal(expected,actual);
    }
}