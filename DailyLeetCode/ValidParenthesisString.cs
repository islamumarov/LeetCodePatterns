namespace DailyLeetCode;

public class ValidParenthesisString
{
    /// <summary>
    /// Given a string s containing only three types of characters: '(', ')' and '*', return true if s is valid.
    /// The following rules define a valid string:
    /// Any left parenthesis '(' must have a corresponding right parenthesis ')'.
    /// Any right parenthesis ')' must have a corresponding left parenthesis '('.
    /// Left parenthesis '(' must go before the corresponding right parenthesis ')'.
    /// '*' could be treated as a single right parenthesis ')' or a single left parenthesis '(' or an empty string "".
    /// </summary>
    /// <param name="s"></param>
    /// <returns></returns>
    public static bool CheckValidString(string s)
    {
        var stack = new Stack<char>();
        var starStack = new Stack<char>();
        foreach (var c in s)
        {
            if (c == '(') stack.Push(c);
            else if (c == '*') starStack.Push(c);
            else
            {
                if (stack.Count > 0) stack.Pop();
                else if (starStack.Count > 0) starStack.Pop();
                else return false;
            }
        }
        while (stack.Count > 0 && starStack.Count > 0)
        {
            if (stack.Pop() != starStack.Pop()) return false;
        }

        if (stack.Count > 0) return false;
        return stack.Count == 0;
    }
}