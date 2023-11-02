namespace SlidingWindow.Hard;

public static class LongestSubstringAfterReplacement
{
    /// <summary>
    /// Given a string with lowercase letters only,
    /// if you are allowed to replace no more than ‘k’ letters with any letter,
    /// find the length of the longest substring having the same letters after replacement.
    /// </summary>
    /// <param name="str">Given string</param>
    /// <param name="k">allowed replacement</param>
    /// <returns>length of the longest substring</returns>
    public static int FindLength(string str, int k)
    {
        var maxLen = -1;
        var windowStart = 0;
        var maxRepeatLetterCount = 0;


        var frequencyMap = new Dictionary<char, int>();

        for (var windowEnd = 0; windowEnd < str.Length; windowEnd++)
        {
            var rightChar = str[windowEnd];
            frequencyMap[rightChar] = frequencyMap.GetValueOrDefault(rightChar) + 1;
            maxRepeatLetterCount = Math.Max(maxRepeatLetterCount, frequencyMap[rightChar]);

            if (windowEnd - windowStart + 1 - maxRepeatLetterCount > k)
            {
                var leftChar = str[windowStart];
                frequencyMap[leftChar] = frequencyMap[leftChar] - 1;
                windowStart++;
            }

            maxLen = Math.Max(maxLen, windowEnd - windowStart + 1);
        }

        return maxLen;
    }
}