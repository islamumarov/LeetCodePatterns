using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyLeetCode;

public class LengthOfLongestFibonacciSubsequence
{
    public static int LenLongestFibSubseq(int[] arr)
    {
        int longest = 0;
        HashSet<int> sum = new HashSet<int>();

        foreach (var a in arr)
        {
            sum.Add(a);
        }

        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = i + 1; j < arr.Length; j++)
            {
                var prev = arr[j];
                var curr = arr[i] + arr[j];
                var currlen = 2;

                while (sum.Contains(curr))
                {
                    currlen++;
                    var tmp = curr;
                    curr = prev + curr;
                    prev = tmp;
                    longest = Math.Max(longest, currlen);
                }
            }
        }

        return longest;
    }
}
