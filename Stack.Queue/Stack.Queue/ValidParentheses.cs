namespace Stack.Queue;

public class ValidParentheses
{
    public static bool IsValid(string s)
    {
        var stack = new Stack<char>();
        var parentheses = new Dictionary<char, char>()
        {
            {
                ')', '('
            },
            {
                ']', '['
            },
            {
                '}', '{'
            }
        };
        foreach (char c in s)
        {
            if (parentheses.ContainsKey(c))
            {
                if (stack.Count == 0 || parentheses[c] != stack.Pop())
                    return false;
            }
            else { stack.Push(c); }
        }
        
        return stack.Count == 0;
    }
}