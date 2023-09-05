namespace SlidingWindow.Medium;

public static class MaxFruitCountOfTwoTypes
{
    /// <summary>
    /// Given an array of characters where each character represents a fruit tree,
    /// you are given two baskets and your goal is to put maximum number of fruits in each basket.
    /// The only restriction is that each basket can have only one type of fruit.
    /// </summary>
    /// <param name="arr">array of characters</param>
    /// <returns>maximum number of fruits</returns>
    public static int FindLength(char[] arr)
    {
        var windowStart = 0;
        var maxLen = -1;
        var basket = new Dictionary<char, int>();
        for (int i = 0; i < arr.Length; i++)
        {
            if (basket.ContainsKey(arr[i]))
                basket[arr[i]]++;
            else
            {
                basket.Add(arr[i], 1);
            }
            while (basket.Count > 2)
            {
                basket[arr[windowStart]]--;
                if (basket[arr[windowStart]] == 0)
                    basket.Remove(arr[windowStart]);
                windowStart++;
            }

            maxLen = Math.Max(maxLen, i - windowStart + 1);
        }
        return maxLen;
    }
}