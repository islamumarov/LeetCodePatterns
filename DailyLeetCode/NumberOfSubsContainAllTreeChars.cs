namespace DailyLeetCode;

public class NumberOfSubsContainAllTreeChars
{
    public static int NumberOfSubstrings(string s)
    {
        int result = 0;
        var windowChars = new Dictionary<char, int>();

        var windowStart = 0;
        var windowEnd = 0;
        while (windowEnd < s.Length)
        {
            if (s[windowEnd] is 'a' or 'b' or 'c')
            {
                windowChars[s[windowEnd]] = windowChars.TryGetValue(s[windowEnd], out var value) ? value + 1 : 1;
            }

            if (windowChars.Count == 3)
            {
                result++;
                result += NumberOfSubstringsInWindow(windowStart, windowEnd,s, windowChars);
            }
           
            windowEnd++;
        }
        return result;
    }

    public static int NumberOfSubstringsInWindow(int windowStart, int end,  string s, Dictionary<char, int> chars)
    {
        var windowChars = new Dictionary<char, int>(chars);
        var result = 0;
        while (windowChars.Count == 3 && windowStart < end)
        {
            var shrinkingChar = s[windowStart];
            windowChars[shrinkingChar] -= 1;
            if (windowChars[shrinkingChar] == 0)
            {
                windowChars.Remove(shrinkingChar);
            }

            if (windowChars.Count == 3)
            {
                result++;
            }
            windowStart++;
        }

        return result;
    }
}