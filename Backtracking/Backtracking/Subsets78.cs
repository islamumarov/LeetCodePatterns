namespace Backtracking;

public class Subsets78
{
    public static IList<IList<int>> Subsets(int[] nums)
    {
        var result = new List<IList<int>>();
        var curPath = new Stack<int>();
        void Backtrack(int start)
        {
            result.Add(curPath.ToList());

            for (int i = start; i < nums.Length; i++)
            {
                curPath.Push(nums[i]);
                Backtrack(i + 1);
                curPath.Pop();
            }
        }

        Backtrack(0);

        return result;
    }
}

