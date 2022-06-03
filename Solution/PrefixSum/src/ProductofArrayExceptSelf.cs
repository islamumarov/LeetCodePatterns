namespace src;

public class ProductofArrayExceptSelf
{
    /// <summary>
    /// Given an integer array nums, return an array answer such that answer[i] is equal to the product of all the elements of nums except nums[i].
    /// The product of any prefix or suffix of nums is guaranteed to fit in a 32-bit integer.
    /// You must write an algorithm that runs in O(n) time and without using the division operation.
    /// </summary>
    /// <param name="nums">Given an integer array nums</param>
    /// <returns>the product of all the elements of nums except nums[i]</returns>
    public static int[] ProductExceptSelf(int[] nums)
    {
        int mult = 1;
        int zeroIndex = -1;
        int? exceptZero = null;
        mult = multipl(nums, ref zeroIndex);

        if (zeroIndex >= 0)
        {
            nums[zeroIndex] = 1;
            exceptZero = multipl(nums, ref zeroIndex);
            
        }
        if (exceptZero !=null)
        {
            Array.Fill(nums,0);
            nums[zeroIndex] = exceptZero.Value;
            return nums;
        }
        for (int i = 0; i < nums.Length; i++)
        {
            nums[i] = nums[i] != 0 ? mult / nums[i] : 0;
        }

        return nums;
    }

    private static int multipl(int[] nums,ref int zeroIndex)
    {
        int mult = 1;
        int zeroCount = 0;
        for (int i = 0; i < nums.Length; i++ )
        {
            if (nums[i] == 0)
            {
                zeroCount++;
                if (zeroCount < 2)
                    zeroIndex = i;
                else zeroIndex = -1;
            }

            mult *= nums[i];
        }
        return mult;
    }
}