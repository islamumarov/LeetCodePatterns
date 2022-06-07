namespace SlidingWindow;

public class RepeatedDNASequences
{
    /// <summary>
    /// The DNA sequence is composed of a series of nucleotides abbreviated as 'A', 'C', 'G', and 'T'.
    /// For example, "ACGAATTCCG" is a DNA sequence.
    /// When studying DNA, it is useful to identify repeated sequences within the DNA.
    /// Given a string s that represents a DNA sequence, return all the 10-letter-long sequences (substrings) that occur more than once in a DNA molecule.
    /// You may return the answer in any order.
    /// https://leetcode.com/problems/repeated-dna-sequences/
    /// </summary>
    /// <param name="s">The DNA sequence</param>
    /// <returns>all the 10-letter-long sequences (substrings) that occur more than once</returns>
    public static IList<string> FindRepeatedDnaSequences(string s)
    {
        List<string> list = new List<string>();
        if (s.Length < 10) return list;
        HashSet<string> set = new HashSet<string>();
        string tmp = "";
        for (int i = 0; i+9 < s.Length; i++)
        {
            tmp = s.Substring(i, 10);
            if (set.Contains(tmp) && !list.Contains(tmp))
                list.Add(tmp);
            else set.Add(tmp);
        }
        return list;
    }
}