namespace src;

public class PermutationOfBrackets
{
    public static List<string> GenerateValidParentheses(int n)
    {
        List<string> permutations = new List<string>();
        Queue<ParenthesesString> queue = new Queue<ParenthesesString>();
        queue.Enqueue(new ParenthesesString("",0,0));
        while (queue.Count > 0)
        {
            ParenthesesString ps = queue.Dequeue();
            if (ps._openCount == n && ps._closeCount == n)
            {
                permutations.Add(ps.str);
            }
            else
            {
                if(ps._openCount < n)
                    queue.Enqueue(new ParenthesesString(ps.str+"(",ps._openCount+1,ps._closeCount));
                if(ps._openCount > ps._closeCount)
                    queue.Enqueue(new ParenthesesString(ps.str + ")", ps._openCount,ps._closeCount+1));
            }
        }

        return permutations;
    }
}

public record ParenthesesString
{
    public string str;
    public int _openCount;
    public int _closeCount;

    public ParenthesesString(string _str, int open, int close)
    {
        this.str = _str;
        this._openCount = open;
        this._closeCount = close;
    }
}