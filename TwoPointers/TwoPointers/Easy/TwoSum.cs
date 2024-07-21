namespace TwoPointers.Easy;

public class TwoSumInSortedArray
{
    public int[] FindTwoSum(int[] nums, int target)
    {
        Array.Sort(nums);
        var first = 0;
        var second = nums.Length - 1;
        while (first < second)
        {
            var sumOfTwo = nums[first] + nums[second];
            if (sumOfTwo > target)
            {
                second--;
            }
            else if (sumOfTwo < target)
            {
                first++;
            }
            else
            {
               break;
            }

        }
        return [first, second];
    }
}