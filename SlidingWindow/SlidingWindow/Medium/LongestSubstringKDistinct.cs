namespace SlidingWindow.Medium;

public class LongestSubstringKDistinct
{
    /*
     * Given a string, find the length of the longest substring in it with no more than K distinct characters.
     * Input: String="araaci", K=2
       Output: 4
     */
    public static int FindLength(string str, int k)
    {
        int maxLen = 0;
        int windowStart = 0;
        var visit = new Dictionary<char, int>();
        for (int i = 0; i < str.Length; i++)
        {
            if (!visit.ContainsKey(str[i]))
            {
                visit.Add(str[i], 1);
            }
            else
                visit[str[i]]++;
            while (visit.Count > k)
            {
                var left = str[windowStart];
                visit[left]--;
                if (visit[left] == 0)
                    visit.Remove(left);
                windowStart++;
            }
            maxLen = Math.Max(maxLen, i - windowStart + 1);
        }
        return maxLen;
    }
}