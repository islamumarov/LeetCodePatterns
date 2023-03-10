namespace src;

public class SortColorsMedium
{
    public static void SortColors(int[] nums)
    {
        var (start, end) = (0, nums.Length - 1);
        int i = 0;
        while (i <= end)
        {
            if (nums[i] == 0)
            {
                (nums[i], nums[start]) = (nums[start], nums[i]);
                i++;
                start++;
                continue;
            }
            if (nums[i] == 2)
            {
                (nums[i], nums[end]) = (nums[end], nums[i]);
                end--;
            }
            else i++;
        }
    }
}