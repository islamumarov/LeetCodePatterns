namespace AnyLeetcode;

public class CountOddNumbersInInterval
{
    // https://leetcode.com/problems/count-odd-numbers-in-an-interval-range/
    public static int CountOdds(int low, int high)
    {
        if (low % 2 == 0) low++;
        return low > high ? 0 : (high - low) / 2 + 1;
    }
}