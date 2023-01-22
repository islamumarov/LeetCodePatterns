using System.Collections.Generic;

namespace SlidingWindowTest;

public  class FindAllAnagrams
{
    public static IList<int> FindAnagrams(string s, string p)
    {
        if (s.Length < p.Length) return new List<int>();
        var patternMap = new Dictionary<char, int>();
        var windowMap = new Dictionary<char, int>();
        var result = new List<int>();
        for (int i = 0; i < p.Length; i++)
        {
            if(!patternMap.ContainsKey(p[i]))
                patternMap.Add(p[i], 0);
            if(!windowMap.ContainsKey(s[i]))
                windowMap.Add(s[i],0);
            patternMap[p[i]]++;
            windowMap[s[i]]++;
        }

        if (IsAnagram(windowMap, patternMap))
        {
            result.Add(0);
        }

        int windowStart = 0;
        windowMap[s[windowStart]]--;
        if (windowMap[s[windowStart]] <= 0) windowMap.Remove(s[windowStart]);
        windowStart++;

        for (int windowEnd = p.Length; windowEnd < s.Length; windowEnd++)
        {
            if(!windowMap.ContainsKey(s[windowEnd])) windowMap.Add(s[windowEnd],0);
            windowMap[s[windowEnd]]++;
            if (IsAnagram(windowMap, patternMap))
            {
                result.Add(windowStart);
            }

            windowMap[s[windowStart]]--;
            if (windowMap[s[windowStart]] <= 0) windowMap.Remove(s[windowStart]);
            windowStart++;
        }

        return result;
    }

    private static bool IsAnagram(Dictionary<char, int> windowMap, Dictionary<char, int> patternMap)
    {
        foreach (var i in windowMap.Keys)
        {
            if (!patternMap.ContainsKey(i) || patternMap[i] != windowMap[i])
                return false;
        }

        return true;
    }
}