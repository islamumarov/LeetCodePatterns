namespace src;

public class BackspaceStringCompare
{
    public static bool BackspaceCompare(string s, string t)
    {
        var sStack = new Stack<char>();
        var tStack = new Stack<char>();

        foreach (var i in s)
        {
            if (i != '#')
                sStack.Push(i);
            else if (sStack.Count > 0)
                sStack.Pop();
        }

        foreach (var i in t)
        {
            if(i != '#')
                tStack.Push(i);
            else if (tStack.Count > 0)
                tStack.Pop();
        }

        while (sStack.Count > 0 && tStack.Count > 0)
        {
            if (sStack.Pop() != tStack.Pop())
                return false;
        }

        return sStack.Count == tStack.Count;
    }

    public static bool WithTwoPointers(string s, string t)
    {
        var pointer1 = s.Length - 1;
        var pointer2 = t.Length - 1;
        while (pointer1 >= 0 || pointer2 >= 0)
        {
            var index1 = NextIndex(s, pointer1);
            var index2 = NextIndex(t, pointer2);

            if (index1 < 0 && index2 < 0) return true;
            if (index1 < 0 || index2 < 0) return false;
            if (s[index1] != t[index2]) return false;

            pointer1 = index1 - 1;
            pointer2 = index2 - 1;
        }

        return true;
    }

    private static int NextIndex(string str, int index)
    {
        var backspaceCount = 0;
        while (index >= 0)
        {
            if (str[index] == '#')
                backspaceCount++;
            else if (backspaceCount > 0)
                backspaceCount--;
            else
                break;
            index--;
        }

        return index;
    }
}