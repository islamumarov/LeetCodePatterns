namespace src;

public class PairWithTargetSum
{
    public static int[] Search(int[] arr, int targetSum)
    {
        var (left, right) = (0, arr.Length-1);
        while (left < right)
        {
            int sum = arr[left] + arr[right];
            if(sum == targetSum)
                return new[] { left, right };
            if (sum > targetSum)
                right--;
            else
                left++;

        }

        return new[] { -1, -1 };
    }
}