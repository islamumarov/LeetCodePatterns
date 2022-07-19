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
}