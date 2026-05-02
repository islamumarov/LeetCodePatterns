

//Unique Length-3 Palindromic Subsequences
//Given a string s, return the number of unique palindromes of length three that are a subsequence of s.
//Note that even if there are multiple ways to obtain the same subsequence, it is still only counted once.
int CountPalindromicSubsequence(string s) {
    var res = 0;
    for (char c = 'a'; c <= 'z'; c++) {
        var first = s.IndexOf(c);
        var last = s.LastIndexOf(c);
        if (first == -1 || first == last) continue;
        var seen = new HashSet<char>();
        for (int i = first + 1; i < last; i++) {
            seen.Add(s[i]);
        }
        res += seen.Count;
    }
    return res;
}