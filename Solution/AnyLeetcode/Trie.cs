using System.Text.RegularExpressions;

namespace AnyLeetcode;

public class Trie
{
    private HashSet<string> _wordsl;
    public Trie()
    {
        _wordsl = new HashSet<string>();
    }
    
    public void Insert(string word)
    {
        this._wordsl.Add(word);
    }
    
    public bool Search(string word)
    {
        return this._wordsl.Contains(word);
    }
    
    public bool StartsWith(string prefix)
    {
        return this._wordsl.FirstOrDefault(x => Regex.IsMatch(x, $"^({prefix})")) != null;
    }

}