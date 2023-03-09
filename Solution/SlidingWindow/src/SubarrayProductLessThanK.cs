namespace SlidingWindow;

public class SubarrayProductLessThanK
{
    public static int NumSubarrayProductLessThanK(int[] nums, int k)
    {
        var windStart = 0;
        var product = 1;
        var count = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            product *= nums[i];
            while (product >= k)
            {
                product /= nums[windStart];
            }

            count += i - windStart + 1;
        }

        return count;
    }
}