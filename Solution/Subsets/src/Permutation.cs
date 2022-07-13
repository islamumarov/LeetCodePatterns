
namespace src;

public class Permutation
{
    public static IList<IList<int>> Permute(int[] nums)
    {
        IList<IList<int>> res = new List<IList<int>>();
        Queue<List<int>> permutations = new Queue<List<int>>();
        permutations.Enqueue(new List<int>());

        foreach (var val in nums)
        {
            int n = permutations.Count;
            for (int i = 0; i < n; i++)
            {
                var prev = permutations.Dequeue();
                for (int j = 0; j <= prev.Count; j++)
                {
                    var next = new List<int>(prev);
                    next.Insert(j,val);
                    if(next.Count == nums.Length)
                        res.Add(next);
                    else
                        permutations.Enqueue(next);

                }

            }

        }
        return res;
    }
}