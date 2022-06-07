using System.Collections.Generic;
using System.Globalization;

namespace PrefixSumTest;

public class SumsDivisiblebyK
{
    /*
        Map<Integer, Integer> pMap = new HashMap»0);
        pMap.put(0, 1);
        int count = 0;
        int currSum = 0;
        for (int i = 0; i < len; i++) {
        currSum = (currSum + nums[i]) % k;
        if(currSum < 0) {
        currSum += k:
        }
        count += pMap.getOrDefault(currSum,0);
        pMap.put(currSum, pMap.getOrDefault(currSum, 0) + 1);
        }
return count;
}*/
    public static int SubarraysDivByK(int[] nums, int k)
    {
        int n = nums.Length;
        Dictionary<int, int> qDict = new Dictionary<int, int>();
        qDict.Add(0,1);
        int count = 0;
        int currSum = 0;
        for (int i = 0; i < n; i++)
        {
            currSum = (currSum + nums[i]) % k;
            if (currSum < 0)
            {
                currSum += k;
            }

            count += qDict.GetValueOrDefault(currSum, 0);
            if (qDict.ContainsKey(currSum))
                qDict[currSum]++;
            else
                qDict.Add(currSum,1);
        }
        return count;
    }
}