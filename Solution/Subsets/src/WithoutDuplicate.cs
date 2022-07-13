namespace src;

public class WithoutDuplicate
{
    
    /// <summary>
    /// Given a set of numbers that might contain duplicates, find all of its distinct subsets.
    /// </summary>
    /// <param name="nums">set of numbers</param>
    /// <returns></returns>
    public static IList<IList<int>> FindSubsetsWithoutDuplicates(int[] nums)
    {
        IList<IList<int>> result = new List<IList<int>>(){new List<int>()};
        Array.Sort(nums);
        int start = 0, end = 0;
        for(var i=0; i < nums.Length; i++)
        {
            start = 0;
            if (i > 0 && nums[i] == nums[i - 1])
                start = end + 1;
            end = result.Count-1;
            for (int j = start; j <= end; j++)
            {
                List<int> set = new List<int>(result[j]);
                set.Add(nums[i]);
                result.Add(set);
            }
        }
        return result;
    }
}