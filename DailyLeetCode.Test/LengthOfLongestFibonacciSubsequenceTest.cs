using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyLeetCode.Test;

public class LengthOfLongestFibonacciSubsequenceTest
{
    [Theory]
    [InlineData(new[] { 1, 2, 3, 4, 5, 6, 7, 8 }, 5)]
    [InlineData(new[] { 2, 4, 7, 8, 9, 10, 14, 15, 18, 23, 32, 50 }, 5)]
    public void AllShouldPass_LenLongestFibSubseq(int[] arr, int expected)
    {
        var actual = LengthOfLongestFibonacciSubsequence.LenLongestFibSubseq(arr);

        Assert.Equal(expected, actual);
    }
}
