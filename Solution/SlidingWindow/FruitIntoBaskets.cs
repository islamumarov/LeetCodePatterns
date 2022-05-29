namespace SlidingWindow;

public class FruitIntoBaskets
{
    /// <summary>
    /// Given an array of characters where each character represents a fruit tree,
    /// you are given two baskets and your goal is to put maximum number of fruits in each basket.
    /// The only restriction is that each basket can have only one type of fruit.
    /// You can start with any tree, but once you have started you can’t skip a tree.
    /// You will pick one fruit from each tree until you cannot, i.e.,
    /// you will stop when you have to pick from a third fruit type.
    /// </summary>
    /// <param name="fruits"></param>
    /// <seealso cref="https://www.educative.io/courses/grokking-the-coding-interview/Bn2KLlOR0lQ"/>
    /// <returns></returns>
    public static int MaxCountOf2Types(char[] fruits)
    {
        Dictionary<char, int> basket = new Dictionary<char, int>();
        int maxLenght = 0;
        int startPoiner = 0;
        for (int i = 0; i < fruits.Length; i++)
        {
            if (basket.ContainsKey(fruits[i]))
            {
                basket[fruits[i]]++;
                continue;
            }
            if (basket.Count >= 2)
            {
                maxLenght = Math.Max(maxLenght, basket.Values.Sum());
                basket.Remove(fruits[startPoiner]);
                startPoiner++;
            }
            basket.Add(fruits[i],1); 
        }

        maxLenght = Math.Max(maxLenght, basket.Values.Sum());
        return maxLenght;
    }
    
}