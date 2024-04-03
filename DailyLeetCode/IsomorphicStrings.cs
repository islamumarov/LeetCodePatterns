namespace DailyLeetCode;

public class IsomorphicStrings
{
    public bool IsIsomorphic(string s, string t)
    {
        var map = new Dictionary<char, char>();
        for (var i = 0; i < s.Length; i++)
        {
            if (map.TryGetValue(s[i], out char value))
            {
                if (value != t[i]) return false;
            }
            else
            {
                if (map.ContainsValue(t[i])) return false;
                map.Add(s[i], t[i]);
            }
        }
        return true;
    }
}