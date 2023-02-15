using System.Numerics;

namespace AnyLeetcode;

public class AddArrayFormOfInteger
{
    // https://leetcode.com/problems/add-to-array-form-of-integer/
    public static IList<int> AddToArrayForm(int[] num, int k)
    {
        BigInteger sum = 0;
        List<int> res = new();
        foreach (var i in num)
        {
            sum *= 10;
            sum += i;
        }

        sum += k;
        while (sum != 0)
        {
            res.Add((int)(sum % 10));
            sum /= 10;
        }

        res.Reverse();
        return res ;
    }

    public static IList<int> AddToArrayForm2(int[] num, int k)
    {
        BigInteger sum = 0;
        List<int> res = new();
        foreach (var i in num)
        {
            sum *= 10;
            sum += i;
        }

        sum += k;
        var sumString = sum.ToString();
        foreach (var val in sumString)
        {
            res.Add(val - '0');
        }

        return res;
    }
}