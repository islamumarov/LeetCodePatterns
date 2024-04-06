namespace SlidingWindow.Medium;

public class SubarrayMaxAtLeastKTimes
{
    public long CountSubarrays(int[] nums, int k)
    {
        var max = nums.Max();
        var count = 0;
        var left = 0;
        long res = 0;
        foreach (var t in nums)
        {
            if (t == max)
            {
                count++;
            }

            while (count == k)
            {
                if (nums[left] == max)
                    count--;
                left++;
            }
            res += left;
        }
        return res;
    }
}
