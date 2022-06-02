namespace SlidingWindow;

public class CharacterReplacement
{
    /// <summary>
    /// 424. Longest Repeating Character Replacement (https://leetcode.com/problems/longest-repeating-character-replacement/)
    /// You are given a string str and an integer k.
    /// You can choose any character of the string and change it to any other uppercase English character.
    /// You can perform this operation at most k times.
    /// </summary>
    /// <param name="str">given a string str</param>
    /// <param name="K">allowed replace K letters.</param>
    /// <returns>Return the length of the longest substring containing the same letter you can get after performing the above operations.</returns>
    public static int FindLength(string str, int K)
    {
        int maxLen = 0;
        int repeat = 0;
        int startPoint = 0;
        Dictionary<char, int> letters = new Dictionary<char, int>();

        for (int i = 0; i < str.Length; i++)
        {
            if (letters.ContainsKey(str[i]))
                letters[str[i]]++;
            else letters.Add(str[i],1);
            repeat = Math.Max(repeat, letters[str[i]]);

            if (i - startPoint + 1 - repeat > K)
            {
                char left = str[startPoint];
                letters[left]-=1;
                startPoint++;
            }
            
            maxLen = Math.Max(maxLen, i-startPoint+1);
        }

        return maxLen;
    }
}