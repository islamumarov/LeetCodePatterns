namespace DailyLeetCode;

public class MakeTheStringGreat
{
    public static string MakeGood(string s)
    {
        var stack = new Stack<char>();
        foreach (var c in s)
        {
            
            if (stack.Count > 0 && stack.Peek() != c && char.ToLower(stack.Peek()) == char.ToLower(c))
                stack.Pop();
            else
                stack.Push(c);
        }
        return new string(stack.Reverse().ToArray());
    }
}