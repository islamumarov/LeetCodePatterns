using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlidingWindow.Medium;

public class SubarrayMaxAtLeastKTimes
{
    public long CountSubarrays(int[] nums, int k)
    {
        var max = nums.Max();
        var maxAppear = 0;
        var (l, r) = (0, 0);
        while (r < nums.Length)
        {
            k -= (nums[r++] == max) ? 1 : 0;

            while (k == 0)
            {
                k += (nums[l++] == max) ? 1 : 0;
            }

            maxAppear += l;
        }

        return maxAppear;
    }
}
