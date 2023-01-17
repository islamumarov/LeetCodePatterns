namespace SlidingWindow;

public class PermutationInString
{
    public static bool CheckInclusion(string s1, string s2)
    {
        if(s1.Length > s2.Length) return false;
        var s1map = new int[26];
        var s2map = new int[26];
        int matches = 0;

        for(int i = 0; i < s1.Length; i++){
            s1map[s1[i] - 'a']++;
            s2map[s2[i] - 'a']++;
        }
        for(int i = 0; i < 26; i++)
        matches += s1map[i] == s2map[i] ? 1 : 0;
        int left = 0;
        for(int right = s1.Length; right < s2.Length; right++){
            if(matches == 26) return true;
            int index = s2[right] - 'a';
            s2map[index]++;
            if(s1map[index] == s2map[index]) matches++;
            else if (s1map[index]+1 == s2map[index]) matches--;

            index = s2[left] - 'a';
            s2map[index]--;
            if(s2map[index] == s1map[index]) matches++;
            else if (s2map[index] == s1map[index]-1) matches--;
            left++;
        }
        return matches == 26;
    }
}