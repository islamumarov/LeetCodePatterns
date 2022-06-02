
// https://leetcode.com/problems/maximum-average-subarray-i/
namespace SlidingWindow
{
    public class MaximumAverageSubarray
    {
        public static double FindMaxAverage(int[] nums, int k) {
            int n = nums.Length;
            double maxAvrg = -1000000;
            int sum=0;
            int j=0;
            for(int i = 0; i < n; i++)
            {
                sum += nums[i];
                if(i >= k-1){
                    double newMaxAvrg = (double)sum / (double)k;
                    maxAvrg = System.Math.Max(newMaxAvrg,maxAvrg);
                    sum -= nums[j++];
                }
            }
            return maxAvrg;
        }
    }
}