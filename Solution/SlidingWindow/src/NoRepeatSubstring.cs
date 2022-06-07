namespace SlidingWindow;

public class NoRepeatSubstring
{
    /// <summary>
    /// Given a string, find the length of the longest substring which has no repeating characters.
    /// 3. Longest Substring Without Repeating Characters
    /// https://leetcode.com/problems/longest-substring-without-repeating-characters/
    /// </summary>
    /// <param name="str">Given string</param>
    /// <returns>length of the longest substring </returns>
    public static int FindLength(string str)
    {
        int maxLen = 0;
        int startPoint = 0;
        Dictionary<char, int> cont = new Dictionary<char, int>();
        for (var index = 0; index < str.Length; index++)
        {
            var t = str[index];
            if (cont.ContainsKey(t))
            {
                maxLen = Math.Max(maxLen, cont.Count);
                while (cont.ContainsKey(t))
                {
                    cont.Remove(str[startPoint]);
                    startPoint++;
                }
            }

            cont.Add(t, 1);
        }

        return Math.Max(maxLen, cont.Count);
    }
}