namespace SlidingWindow.Medium;

public class FindRepeatedSequences
{
    /// <summary>
    /// Given a string, s, that represents a DNA subsequence, and a number
    /// k, return all the contiguous subsequences (substrings) of length k
    /// that occur more than once in the string. The order of the returned subsequences does not matter. If no repeated substring is found, the function should return an empty set.
    /// </summary>
    /// <param name="s">DNA sequence</param>
    /// <param name="k">k length subsequence</param>
    /// <returns>subsequences (substrings) of length k that occur more than once in the string</returns>
    public static HashSet<string> FindRepeatedSequencesOfDNA(string s, int k)
    {
        var result = new HashSet<string>();
        var dict = new Dictionary<string, int>();
        var windowStart = 0;
        var currentWindow = "";
        for (int i = 0; i < s.Length; i++)
        {
            currentWindow += s[i];
            while (currentWindow.Length == k)
            {
                if (dict.ContainsKey(currentWindow))
                {
                    result.Add(currentWindow);
                }
                else
                {
                    dict.Add(currentWindow, 1);
                }

                currentWindow = currentWindow.Substring(1, currentWindow.Length - 1);
            }
        }
        return result;
    }
}