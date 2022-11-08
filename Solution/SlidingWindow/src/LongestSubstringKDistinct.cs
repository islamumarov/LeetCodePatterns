namespace SlidingWindow;

public class LongestSubstringKDistinct
{
    public static int FindLength(String str, int k)
    {
        int start = 0;
        int maxLen = 0;
        Dictionary<char, int> frequent = new Dictionary<char, int>();

        for (int i = 0; i < str.Length; i++)
        {
            var current = str[i];
            if (frequent.ContainsKey(current))
                frequent[current]++;
            else frequent.Add(str[i],1);
            while (frequent.Count >= k)
            {
                var leftchar = str[start];
                frequent[leftchar]--;
                if (frequent[leftchar] == 0)
                    frequent.Remove(leftchar);
                maxLen = Math.Max(maxLen, start - i + 1);
            }
        }

        return maxLen;
    }
}