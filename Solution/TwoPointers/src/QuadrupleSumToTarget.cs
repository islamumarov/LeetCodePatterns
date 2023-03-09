using System.Numerics;

namespace src;

public class QuadrupleSumToTarget
{
    public static List<IList<int>> SearchQuadruple(int[] nums, int target)
    {
        var result = new List<IList<int>>();
        if (nums.Length < 4) return result;
        Array.Sort(nums);

        for (int i = 0; i < nums.Length-3; i++)
        {
            if(i > 0 && nums[i] == nums[i-1])continue;
            for (int j = i+1; j < nums.Length-2; j++)
            {
                if(j > i+1  && nums[j] == nums[j-1]) continue;
                Quadruple(nums, i, j, target, result);
            }
        }
        return result;
    }

    public static void Quadruple(int[] nums, int first, int second, int target, List<IList<int>> res)
    {
        var (left, right) = (second + 1, nums.Length - 1);
        while (left < right)
        {
            long current = (long)nums[first] + nums[second] + nums[left] + nums[right];
            if (current == target)
            {
                res.Add(new List<int> {nums[first], nums[second], nums[left], nums[right]});
                left++;
                right--;
                while (left < right && nums[left] == nums[left - 1]) left++;
                while (left < right && nums[right] == nums[right+1]) right--;
            }
            else if (current > target)
                right--;
            else left++;
        }
    }
}