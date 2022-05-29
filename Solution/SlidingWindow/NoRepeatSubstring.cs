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
        for (int i = 0; i < str.Length; i++)
        {
            if (cont.ContainsKey(str[i]))
            {
                maxLen = Math.Max(maxLen, cont.Count);
                while (cont.ContainsKey(str[i]))
                {
                    cont.Remove(str[startPoint]);
                    startPoint++;
                }
            }
            cont.Add(str[i],1);
        }

        return Math.Max(maxLen, cont.Count);
    }
}