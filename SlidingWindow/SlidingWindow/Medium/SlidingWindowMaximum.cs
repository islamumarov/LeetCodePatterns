namespace SlidingWindow.Medium;

public class SlidingWindowMaximum
{
    public static int[] FindMaxSlidingWindow(int[] nums, int w)
    {
        if (nums.Length <= w)
            return new List<int> { nums.Max() }.ToArray();
        //var result = new PriorityQueue<KeyValuePair<int, int>>();

        int windowStart = 0;
        var windowMax = int.MinValue;
        //return result.ToArray();
        return new int[2];
    }
}