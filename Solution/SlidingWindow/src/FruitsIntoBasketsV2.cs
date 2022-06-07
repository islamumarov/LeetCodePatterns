namespace SlidingWindow;
/// <summary>
/// 904. Fruit Into Baskets
/// </summary>
public class FruitsIntoBasketsV2
{

    /// <summary>
    /// You are visiting a farm that has a single row of fruit trees arranged from left to right.
    /// The trees are represented by an integer array fruits where fruits[i] is the type of fruit the ith tree produces.
    /// You want to collect as much fruit as possible. However, the owner has some strict rules that you must follow:
    ///     You only have two baskets, and each basket can only hold a single type of fruit. There is no limit on the amount of fruit each basket can hold.
    ///     Starting from any tree of your choice, you must pick exactly one fruit from every tree (including the start tree) while moving to the right. The picked fruits must fit in one of your baskets.
    ///     Once you reach a tree with fruit that cannot fit in your baskets, you must stop.
    /// See https://leetcode.com/problems/fruit-into-baskets/submissions/
    /// </summary>
    /// <param name="fruits">Given the integer array fruits</param>
    /// <returns> return the maximum number of fruits you can pick.</returns>
    public static int TotalFruit(int[] fruits)
    {   Dictionary<int, int> baskets = new Dictionary<int, int>(2);
        int maxAmount = 0;
        int startPoint = 0;
        for (int i = 0; i < fruits.Length; i++)
        {
            if (baskets.ContainsKey(fruits[i]))
            {
                baskets[fruits[i]]++;
                continue;
            }

            if (baskets.Count >= 2)
            {   maxAmount = Math.Max(maxAmount, baskets.Values.Sum());
                while (baskets.Count >= 2)
                {
                    baskets[fruits[startPoint]]--;
                    if (baskets[fruits[startPoint]] == 0)
                        baskets.Remove(fruits[startPoint]);
                    startPoint++;
                }
            }
            baskets.Add(fruits[i],1);
        }

        maxAmount = Math.Max(maxAmount, baskets.Values.Sum());
        return maxAmount;
    }

}