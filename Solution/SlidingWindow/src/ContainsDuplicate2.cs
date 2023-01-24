namespace SlidingWindow;

public class ContainsDuplicate2
{
    public static bool ContainsNearbyAlmostDuplicate(int[] nums, int k, int t)
    {
        var currentWindow = new List<int>();
        for (int i = 0; i < k; i++)
        {
            foreach (var val in currentWindow)
            {
                if (Math.Abs(val - nums[i]) <= t)
                    return true;
            }
            currentWindow.Add(nums[i]);
        }

        var windowStart = 0;
        for (int i = k; i < nums.Length; i++)
        {
            var currentDiff = nums[i];
            foreach (var val in currentWindow)
            {
                if (Math.Abs(nums[i] - val) <= t && Math.Abs(windowStart-i) <= k)
                    return true;
            }
            currentWindow.Add(currentDiff);
            currentWindow.Remove(Math.Abs(nums[windowStart]));
            windowStart++;
        }

        return false;
    }
}