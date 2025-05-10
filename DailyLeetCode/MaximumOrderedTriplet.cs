namespace DailyLeetCode;

public class MaximumOrderedTriplet
{
    public static long MaximumTripletValue_MaxQueue(int[] nums)
    {

        if (nums.Length < 3) return 0;
        var maxQueue = new PriorityQueue<int[], long>(comparer: Comparer<long>.Create(((i, i1) => (i < i1) ? 1 : -1)));

        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = i+1; j < nums.Length; j++)
            {
                for (int k = j+1; k < nums.Length; k++)
                {
                    long val = (nums[i] - nums[j]) * (long) nums[k];
                    maxQueue.Enqueue([i,j,k], val);
                }
            }
        }
        
        var max = maxQueue.Dequeue();
        long value = (nums[max[0]] - nums[max[1]]) * (long)nums[max[2]];
        return value < 0 ? 0 : value;
    }
    
    public static long MaximumTripletValue_PrefixSum(int[] nums)
    {
        return 0;
    }
}