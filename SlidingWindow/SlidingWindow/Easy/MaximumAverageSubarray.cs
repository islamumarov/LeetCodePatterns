namespace SlidingWindow.Easy;

public class MaximumAverageSubarray
{
    public static double FindMaxAverage(int[] nums, int k)
    {
        int windowEnd = 0;
        double maxAvgSum = double.MinValue;
        int windowSum = 0;
        for (int i = 0; i < nums.Length && windowEnd < nums.Length; i++)
        {
            while (windowEnd - i < k && windowEnd < nums.Length)
            {
                windowSum += nums[windowEnd];
                windowEnd++;
            }
            maxAvgSum = Math.Max(maxAvgSum, (double)windowSum / k);
            windowSum -= nums[i];
        }

        return maxAvgSum;
    }
}