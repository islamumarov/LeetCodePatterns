namespace src;

public class MergeIntervals
{
    /// <summary>
    /// Given an array of intervals where intervals[i] = [starti, endi], merge all overlapping intervals,
    /// and return an array of the non-overlapping intervals that cover all the intervals in the input.
    /// Input: intervals = [[1,3],[2,6],[8,10],[15,18]]
    /// Output: [[1,6],[8,10],[15,18]]
    /// Explanation: Since intervals [1,3] and [2,6] overlap, merge them into [1,6].
    /// </summary>
    /// https://leetcode.com/problems/merge-intervals/
    /// <param name="intervals"> array of intervals</param>
    /// <returns> non-overlapping intervals</returns>
    public static int[][] Merge(int[][] intervals)
    {
        if (intervals.Length == 0) return intervals;
        
        Array.Sort(intervals,(a,b) => a[0] - b[0]);
        List<int[]> res = new List<int[]>();
        int[] cur = intervals[0];
        for (int i = 1; i < intervals.Length; i++)
        {
            if (intervals[i][0] <= cur[1])
            {
                cur[1] = Math.Max(cur[1], intervals[i][1]);
            }
            else
            {
                res.Add(cur);
                cur = intervals[i];
            }
        }
        res.Add(cur);
        return res.ToArray();
    }
}