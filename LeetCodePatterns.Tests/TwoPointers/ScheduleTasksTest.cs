namespace LeetCodePatterns.Tests;

public class ScheduleTasksTest
{
    [Fact]
    public void Test1()
    {
        var tasks = new int[][]
        {
            new int[] { 1, 7 },
            new int[] { 8, 13 },
            new int[] { 5, 6 },
            new int[] { 10, 14 },
            new int[] { 6, 7 },
        };

        var result = ScheduleTasks.MinimumMachines(tasks);

        Assert.Equal(2, result);
    }

    [Fact]
    public void Test2()
    {
        //[[1,4],[3,5],[6,8],[7,8]]
        var tasks = new int[][]
        {
            new int[] { 1, 4 },
            new int[] { 3, 5 },
            new int[] { 6, 8 },
            new int[] { 7, 8 },
        };

        var result = ScheduleTasks.MinimumMachines(tasks);

        Assert.Equal(2, result);
    }

    [Fact]
    public void Test3()
    {
        //[[1,7],[1,7],[1,7],[1,7],[1,7],[1,7]]
        var tasks = new int[][]
        {
            new int[] { 1, 7 },
            new int[] { 1, 7 },
            new int[] { 1, 7 },
            new int[] { 1, 7 },
            new int[] { 1, 7 },
            new int[] { 1, 7 },
        };

        var result = ScheduleTasks.MinimumMachines(tasks);

        Assert.Equal(2, result);
    }
}
