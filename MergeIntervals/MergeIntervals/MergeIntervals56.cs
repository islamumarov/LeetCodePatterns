namespace MergeIntervals;

public class MergeIntervals56
{
    public static int[][] Merge(int[][] intervals)
    {
        Array.Sort(intervals, (a, b) => a[0] - b[0]);

        var newIntervals = new List<int[]>() { new int[2] {intervals[0][0], intervals[0][1]} };
        int first = 0;
        for(int i = 1; i < intervals.Length; i++)
        {
            if(newIntervals[first][0] <= intervals[i][0] && intervals[i][0] <= newIntervals[first][1])
            {
                var maxEnd = Math.Max(newIntervals[first][1], intervals[i][1]);
                newIntervals.Add([newIntervals[first][0], maxEnd]);
                newIntervals.Remove(newIntervals[first]);
            }
            else{
                newIntervals.Add([intervals[i][0],intervals[i][1]]);
            }
        }
        return newIntervals.ToArray();
    }
}
