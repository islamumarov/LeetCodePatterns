namespace DailyLeetCode;

public class LengthOfLastWordSolution
{
    public static int LengthOfLastWord(string s)
    {
        var res = s.Split(" ").LastOrDefault(s => s.Length > 0);
        return res?.Length ?? 0;
    }
}