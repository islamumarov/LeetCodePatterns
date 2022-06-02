namespace SlidingWindow;
/// <summary>
/// Problem Statement
/// Given an array of positive numbers and a positive number ‘S,’
/// find the length of the smallest contiguous subarray whose sum is greater than or equal to ‘S’.
/// Return 0 if no such subarray exists
/// link: https://leetcode.com/problems/minimum-size-subarray-sum/
/// </summary>
public class MinSizeSubArraySum
{
    public static int findMinSubArray(int[] arr,int S)
    {
        int windowSum = 0;
        int minLen = arr.Length+S;
        int lenWindow = 0;
        int j = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            windowSum += arr[i];
            lenWindow++;
            while (windowSum >= S)
            {
                minLen = Math.Min(minLen, lenWindow);
                windowSum -= arr[j++];
                lenWindow--;
            }
        }

        return minLen < arr.Length + S ? minLen : 0;
    }
}