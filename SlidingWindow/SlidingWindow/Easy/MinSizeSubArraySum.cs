namespace SlidingWindow.Easy;

public static class MinSizeSubArraySum
{
    public static int FindMinSubArray(int s, int[] arr)
    {
        var minSize = int.MaxValue;
        int windowStart = 0;
        int windowSum = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            windowSum += arr[i];
            while (windowSum >= s)
            {
                minSize = Math.Min(minSize, i - windowStart + 1);
                windowSum -= arr[windowStart];
                windowStart++;
            }
        }

        return minSize == int.MaxValue ? 0 : minSize;
    }
}