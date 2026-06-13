using Graphs;

namespace GraphTests;

public class CourseScheduleTests
{
    [Theory]
    [MemberData(nameof(GetTestData))]
    public void CanFinish_AllShouldPass(int numCourses, int[][] prerequisites, bool expected)
    {
        var actual = CourseSchedule.CanFinish(numCourses, prerequisites);
        Assert.Equal(expected, actual);
    }

    public static IEnumerable<object[]> GetTestData()
    {
        yield return new object[] { 2, new int[][] { new int[] { 1, 0 } }, true };
        yield return new object[]
        {
            2,
            new int[][] { new int[] { 1, 0 }, new int[] { 0, 1 } },
            false
        };
        // [[1,4],[2,4],[3,1],[3,2]]
        yield return new object[]
        {
            5,
            new int[][]
            {
                new int[] { 1, 4 },
                new int[] { 2, 4 },
                new int[] { 3, 1 },
                new int[] { 3, 2 }
            },
            true
        };
    }
}
