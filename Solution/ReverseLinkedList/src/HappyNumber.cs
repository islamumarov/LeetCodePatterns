namespace src;

public class HappyNumber
{
    /*
     * Write an algorithm to determine if a number n is happy.

A happy number is a number defined by the following process:

Starting with any positive integer, replace the number by the sum of the squares of its digits.
Repeat the process until the number equals 1 (where it will stay), or it loops endlessly in a cycle which does not include 1.
Those numbers for which this process ends in 1 are happy.
Return true if n is a happy number, and false if not.
     */
    public static bool IsHappy(int n)
    {
        int slow = n;
        int fast = getNext(n);

        while (fast != 1 && slow != fast)
        {
            slow = getNext(slow);
            fast = getNext(getNext(fast));
        }

        return fast == 1;
    }

    private static int getNext(int n)
    {
        int totalSum = 0;
        while (n > 0)
        {
            var d = n % 10;
            n = n / 10;
            totalSum += d * d;
        }

        return totalSum;
    }
}