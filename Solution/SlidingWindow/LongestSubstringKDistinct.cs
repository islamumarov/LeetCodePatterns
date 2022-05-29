namespace SlidingWindow;

public class LongestSubstringKDistinct
{
    public static int FindLength(String str, int k)
    {
        int start = 0;
        int maxLenght = 0;
        Dictionary<char, int> charFrequency = new Dictionary<char, int>();
        for (int i = 0; i < str.Length; i++)
        {
            char r = str[i];
            if(charFrequency.ContainsKey(r))
                charFrequency.Add(r,0);
            charFrequency[r] += 1;
            while (charFrequency.Count > k)
            {
                char l = str[start++];
                charFrequency[l] -= 1;
                if (charFrequency[l] == 0)
                    charFrequency.Remove(l);
            }

            maxLenght = Math.Max(maxLenght, start - i);
        }

        return maxLenght;
    }
}