namespace src;

public class FindFirstLastPos
{
    public static int[] SearchRange(int[] nums, int target)
    {
        List<int> f = new List<int>();
        int low = 0;
        int high = nums.Length;
        while (low < high)
        {
            int mid = (high - low) / 2;
            if (target < nums[mid]) high = mid - 1;
            if (target > nums[mid]) low = mid + 1;
            else
            {
                f.Add(mid);
            }
        };
        f.Sort();
        return f.ToArray();

    }
}