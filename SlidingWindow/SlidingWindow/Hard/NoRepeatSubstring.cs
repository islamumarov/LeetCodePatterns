namespace SlidingWindow.Hard;

public static class NoRepeatSubstring
{
    /// <summary>
    /// Given a string, find the length of the longest substring which has no repeating characters.
    /// </summary>
    /// <param name="str">string</param>
    /// <returns>length of no repeating characters</returns>
    /// <param name="LeetCode source">https://leetcode.com/problems/longest-substring-without-repeating-characters/</param>
    public static int FindLength(string str)
    {
        var maxLen = 0;
        var dict = new Dictionary<char, int>();
        var windowStart = 0;
        for (int i = 0; i < str.Length; i++)
        {
            var currentChar = str[i];
            if (dict.TryGetValue(currentChar, out int val))
            {
                windowStart = Math.Max(windowStart, val + 1);
            }

            dict[currentChar] = i;
            maxLen = Math.Max(maxLen, i - windowStart + 1);

        }
        return maxLen;
    }
}