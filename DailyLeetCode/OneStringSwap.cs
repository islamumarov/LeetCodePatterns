namespace DailyLeetCode;

public  class OneStringSwap
{
    /// <summary>
    /// You are given two strings s1 and s2 of equal length. A string swap is an operation where you choose two indices in a string (not necessarily different) and swap the characters at these indices.
    /// Return true if it is possible to make both strings equal by performing at most one string swap on exactly one of the strings. Otherwise, return false.
    /// </summary>
    /// <param name="s1"></param>
    /// <param name="s2"></param>
    /// <returns></returns>
    
    public static bool AreAlmostEqual(string s1, string s2)
    {
        var first = -1;
        var second = -1;
        var swapCount = 0;
        
        for (int i = 0; i < s1.Length; i++)
        {
            if (s1[i] != s2[i])
            {
                switch (swapCount)
                {
                    case > 1:
                        return false;
                    case 0:
                        first = i;
                        break;
                    default:
                        second = i;
                        break;
                }

                swapCount++;
            }
        }

        for (int i = 0; i < s1.Length; i++)
        {
            if (i == first && second >= 0)
            {
                if (s1[i] != s2[second])
                {
                    return false;
                }
            }

            if (i == second && first >= 0)
            {
                if (s1[i] != s2[first])
                {
                    return false;
                }
            }
        }

        return first == second || second > 0;
    }
}