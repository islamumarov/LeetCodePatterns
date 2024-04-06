using System.Text;
namespace DailyLeetCode;

public class MinimumRemoveMakeValidParentheses
{
    public static string MinRemoveToMakeValid(string s)
    {
        var stack = new Dictionary<char, Stack<int>>();
        for (var i = 0; i < s.Length; i++)
        {
            if (s[i] == '(')
            {
                if (!stack.ContainsKey(s[i]))
                    stack[s[i]] = new Stack<int>();
                stack[s[i]].Push(i);
            }
            else if (s[i] == ')')
            {
                if (stack.ContainsKey('('))
                {
                    stack['('].Pop();
                    if (stack['('].Count < 1)
                        stack.Remove('(');
                }
                else
                {
                    s = s.Remove(i, 1);
                    i--;
                }
            }
        }

        stack.TryGetValue('(', out var opens);
        while (opens?.Count > 0)
            s = s.Remove(opens.Pop(), 1);
        return s;
    }
}