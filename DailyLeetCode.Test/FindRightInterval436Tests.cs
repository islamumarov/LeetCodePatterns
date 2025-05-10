namespace DailyLeetCode.Test;

public class FindRightInterval436Tests
{
    [Fact]
    
    public void FindRightInterval_AllShouldPass()
    {
        var intervals = new int[3][];
        intervals[0] = new int[]{1,4};
        intervals[1] = new int[]{2,3};
        intervals[2] = new int[]{3,4};
        
        var actual = FindRightInterval436.FindRightInterval(intervals);
        var expected = new int[]{-1, 2,-1};
        
        Assert.Equal(expected, actual);
    }
}