using System.Text;

namespace DFS;

public class ConcatenatedWords472 {
    public static IList<string> FindAllConcatenatedWordsInADict(string[] words) {
        var wordSet = new HashSet<string>(words);
        
        var result = new List<string>();
        foreach (var word in words)
        {
            if(DFS(word, wordSet))
                result.Add(word);
        }
        
        return result;
    }


    public static bool DFS(string word, HashSet<string> wordSet)
    {
        for (int i = 1; i < word.Length; i++)
        {
            var prefix = word.Substring(0, i);
            var suffix = word.Substring(i);
            
            if(wordSet.Contains(prefix) && wordSet.Contains(suffix))
                return true;
            if(wordSet.Contains(prefix) && DFS(suffix, wordSet))
                return true;
            if(wordSet.Contains(suffix) && DFS(prefix, wordSet))
                return true;
            
        }
        return false;
    }
}