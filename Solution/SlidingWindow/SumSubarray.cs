using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlidingWindow
{
    public class SumSubarray
    {
        public static double[] findAverages(int[] arr, int K)
        {
            double[] result = new double[arr.Length - K + 1];
            int windowSum = 0;
            int Start = 0;
            for (int End = 0; End < arr.Length; End++)
            {
                windowSum += arr[End];
                if (End >= K - 1)
                {
                    result[Start] = windowSum / (double)K;
                    windowSum -= arr[Start];
                    Start++;
                }
            }
            return result;
        }
    }
}
