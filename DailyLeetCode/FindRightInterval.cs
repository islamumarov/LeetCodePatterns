namespace DailyLeetCode;

public class FindRightInterval436
{
    public static int[] FindRightInterval(int[][] intervals) {
        
        Array.Sort(intervals, (a, b) => a[0].CompareTo(b[0]));
        var ans = new int[intervals.Length];
        Array.Fill(ans, -1);
        for (int i = 0; i < intervals.Length; i++)
        {
            var left = 0;
            var right = intervals.Length - 1;
            var mid = left + (right - left) / 2;
            if(intervals[i][1] < intervals[mid][1])
            {
                while (intervals[i][1] > intervals[mid][1] && mid > 0)
                {
                    left = mid + 1;
                    mid = left + (right - left) / 2;
                }
                
            }
            else
            {
                while (intervals[i][1] < intervals[mid][1] && mid > 0)
                {
                    right = mid - 1;
                    mid = left + (right - left) / 2;
                }
            }
            
            ans[i] = mid;
        }

        return ans;
    }
}