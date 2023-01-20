namespace SlidingWindow;

public class MinimumWindowSubstring
{
    public static string MinWindow(string s, string t)
    {
        var tMap = new Dictionary<char, int>();
        var sMap = new Dictionary<char, int>();

        int left = 0;
        foreach (var i in t)
        {
            if (!tMap.ContainsKey(i))
            {
                tMap.Add(i,0);
            }

            tMap[i]++;
        }

        var lr = new int[2] { 0, 0 };
        var (have, need) = (0, tMap.Count);
        var resLen = int.MaxValue;
        for (int right = 0; right < s.Length; right++)
        {
            var c = s[right];
            if (!sMap.ContainsKey(c))
            {
                sMap.Add(c,0);
            }

            sMap[c]++;
            if (tMap.ContainsKey(c) && tMap[c] == sMap[c])
                have++;

            while (have == need)
            {
                if ((right - left + 1) < resLen)
                {
                    lr = new[] { left, right };
                    resLen = right - left + 1;
                }

                sMap[s[left]]--;
                if (tMap.ContainsKey(s[left]) && sMap[s[left]] < tMap[s[left]])
                    have--;
                left++;
            }
        }

        return resLen != int.MaxValue ? s.Substring(lr[0], lr[1] - lr[0]+1) : "";
    }
}