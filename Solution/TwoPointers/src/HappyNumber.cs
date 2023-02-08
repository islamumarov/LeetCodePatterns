namespace src;

public class HappyNumber
{
    public static bool FindHappyNumber(int num)
    {
        var (fast,slow) = (num, num);
        while (true)
        {
            slow = GetArrayOfDigits(slow);
            fast = GetArrayOfDigits(GetArrayOfDigits(fast));
            if(slow == fast) break;
        }

        return slow == 1;
    }

    public static int GetArrayOfDigits(int num)
    {

        int sum = 0;
        while (num > 0)
        {
            var tmp = num % 10;
            sum += tmp * tmp;
            num /= 10;
        }

        return sum;
    }
}