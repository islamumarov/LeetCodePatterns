namespace MergeIntervals;

public class MinMergeIntervals
{
    public static int Merge(int[][] intervals)
    {
        Array.Sort(intervals, (interval1, interval2) => interval1[0] - interval2[0]);
        var first = 0;
        var newIntervals = new List<int[]>() { intervals[0] };

        for (int i = 1; i < intervals.Length; i++)
        {
            if (newIntervals[first][0] <= intervals[i][0] && newIntervals[first][1] > intervals[i][0])
            {
                var min_end = Math.Min(intervals[i][1], newIntervals[first][1]);
                newIntervals.Add([newIntervals[first][0], min_end]);
                newIntervals.Remove(newIntervals[first]);
            }
            else
            {
                newIntervals.Add(intervals[i]);
                first++;
            }
        }
        return intervals.Length - newIntervals.Count;
    }
}
