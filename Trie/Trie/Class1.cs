namespace Trie;
public class TrieNode
{
    public bool IsWord { get; set; }
    public Dictionary<int, TrieNode> Children { get; } = new Dictionary<int, TrieNode>();
}
public class TrieImplementation 
{
    private static readonly TrieNode _root = new TrieNode();

    public static int[] GetArray(int number)
    {
        var list = new List<int>();

        while (number / 10 != 0)
        {
            list.Add(number % 10);
            number /= 10;
        }
        list.Reverse();
        
        return list.ToArray();
    }
    public static int LongestCommonPrefix(int[] arr1, int[] arr2)
    {
        foreach (var i in arr1)
        {
            AddWord(i);
        }

        var max = 0;
        foreach(var i in arr2)
        {
            var nums = GetArray(i);
            var curr = Search(nums);
            max = Math.Max(max, curr);
        }

        return max;
    }
    
    public static void AddWord(int number)
    {
        var nums = GetArray(number);
        var node = _root;
        foreach (int c in nums)
        {
            if (!node.Children.ContainsKey(c))
                node.Children[c] = new TrieNode();
            node = node.Children[c];
        }
        node.IsWord = true;
    }
    public static int Search(int[] word)
    {
        var node = _root;
        var depth = 0;
        foreach (var c in word)
        {
            if (!node.Children.TryGetValue(c, out var child))
                return depth+1;
            node = child;
            depth++;
        }
        return depth;
    }
}