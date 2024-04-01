namespace DailyLeetCode;

public class LengthOfLastWord
{
    public int LengthOfLastWord(string s)
    {
        var res = s.Split(" ");
        return res.LastOrDefault(s => s.Length > 0).Length;
    }
}