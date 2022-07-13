namespace src;

public class PermutSubsets
{
    /// <summary>
    /// 78. Subsets
    /// Given an integer array nums of unique elements, return all possible subsets (the power set).
    /// The solution set must not contain duplicate subsets. Return the solution in any order.
    /// </summary>
    /// <param name="nums"></param>
    /// <returns></returns>
    public static IList<IList<int>> FindSubsets(List<int> nums)
    {
        IList<IList<int>> permutate = new List<IList<int>> { new List<int>() };

        foreach (var i in nums)
        {
            int n = permutate.Count;
            for (int j = 0; j < n; j++)
            {
                List<int> set = new List<int>(permutate[j]);
                set.Add(i);
                permutate.Add(set);

            }
        }
        return permutate;
    }
}