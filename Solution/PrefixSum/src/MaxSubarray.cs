namespace src;

public class MaxSubarray
{

    /// <summary>
    /// Given an integer array nums, find the contiguous subarray (containing at least one number)
    /// which has the largest sum and return its sum.
    /// A subarray is a contiguous part of an array.
    /// </summary>
    /// <param name="nums">array nums</param>
    /// <returns>the largest sum</returns>
    public static int FindLargestSum(int[] nums)
    {
        if (nums.Length < 2) return nums[0];
        int maxSF = int.MinValue;
        int current = 0;
        foreach (var i in nums)
        {
            current = Math.Max(current + i, i);
            maxSF = Math.Max(current, maxSF);
        }

        return maxSF;
    }


    public static int[] Sm(int[] nums)
    {
        int[] prefixSum = new int[nums.Length];
        prefixSum[0] = nums[0];
        for (int i = 1; i < nums.Length; i++)
        {
            prefixSum[i] = prefixSum[i - 1] + nums[i];
        }

        return prefixSum;
    }
}