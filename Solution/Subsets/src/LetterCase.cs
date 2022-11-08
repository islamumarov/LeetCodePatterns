namespace src;

public class LetterCase
{
    public static List<string> LetterCasePermutation(string str)
    {
        List<string> permut = new List<string> { str };

        for (int i = 0; i < str.Length; i++)
        {
            if(Char.IsDigit(str[i])) continue; 
            int n = permut.Count;
            for (int j = 0; j < n; j++)
            {
                var tmp = permut[j].ToCharArray();
                tmp[i] = Char.IsUpper(tmp[i]) ? Char.ToLower(tmp[i]) : Char.ToUpper(tmp[i]);
                permut.Add(new string(tmp));
            }
        }
        return permut;
    }

    // ------------ no context. dp task pascal triangle from daily context
    public static List<IList<int>> Generate(int n)
    {
        var pascal =  new List<IList<int>>();
        pascal.Add(new List<int>(){1});
        if (n == 1) return pascal;
        pascal.Add(new List<int>(){1,1});
        for (int i = 2; i < n; i++)
        {
            var tmp = new List<int>(){1};
            var l = pascal[i - 1];
            for (int j = 1; j < l.Count ; j++)
            {
                tmp.Add(l[j]+l[j-1]);
            }
            tmp.Add(1);
            pascal.Add(tmp);
        }
        return pascal;
    }
}