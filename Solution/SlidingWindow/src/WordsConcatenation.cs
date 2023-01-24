namespace SlidingWindow;

public class WordsConcatenation
{
    public static List<int> FindWordConcatenation(string str, string[] words)
    {
        var result = new List<int>();
        var wordsMap = new Dictionary<string, int>();
        foreach (var val in words)
        {
            if(!wordsMap.ContainsKey(val))
                wordsMap.Add(val, 0);
            wordsMap[val]++;
        }

        var wordsCount = words.Length;
        var wordsLen = words[0].Length;
        for (int i = 0; i <= str.Length - wordsCount * wordsLen; i++)
        {
            var wordsSeen = new Dictionary<string, int>();
            for (int j = 0; j < wordsCount; j++)
            {
                var nextWordIndex = i + j * wordsLen;
                var currentWord = str.Substring(nextWordIndex, wordsLen);
                if(!wordsMap.ContainsKey(currentWord))
                    break;
                if(!wordsSeen.ContainsKey(currentWord)) wordsSeen.Add(currentWord,0);
                wordsSeen[currentWord]++;
                if(wordsSeen[currentWord] > wordsMap[currentWord])
                    break;
                if(j + 1 == wordsCount)
                    result.Add(i);
            }
        }
        return result;
    }
}