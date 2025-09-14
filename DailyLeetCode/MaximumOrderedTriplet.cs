namespace DailyLeetCode;

public class MaximumOrderedTriplet
{
    public static long MaximumTripletValue_MaxQueue(int[] nums)
    {

        if (nums.Length < 3) return 0;
        var maxValue = long.MinValue;
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = i+1; j < nums.Length; j++)
            {
                for (int k = j+1; k < nums.Length; k++)
                {
                    long val = (nums[i] - nums[j]) * (long) nums[k];
                    maxValue = Math.Max(maxValue, val);
                }
            }
        }
        
        return maxValue < 0 ? 0 : maxValue;
    }
    
    public static long MaximumTripletValue_PrefixSum(int[] nums)
    {
        if (nums.Length < 3) return 0;
        
        var maxVal = long.MinValue;

        for (int i = 0; i < nums.Length; i++)
        {
            
        }
        
        
        return 0;
    }
}