namespace TwoPointers.Easy;

public class SquaresSortedArray
{
    public int[] SortedSquares(int[] nums)
    {
        var (l, r) = (0, nums.Length - 1);
        var ans = new int[nums.Length];
        for (var i = nums.Length - 1; i >= 0; i--)
        {
            if (Math.Abs(nums[l]) > Math.Abs(nums[r]))
            {
                ans[i] = nums[l] * nums[l];
                l++;
            }
            else
            {
                ans[i] = nums[r] * nums[r];
                r--;
            }
        }
        return ans;
    }
}
