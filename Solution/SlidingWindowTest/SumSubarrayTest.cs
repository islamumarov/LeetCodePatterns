using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using SlidingWindow;

namespace SlidingWindowTest
{
    public class SumSubarrayTest
    {
        [Theory]
        [InlineData(new int[] { 1, 3, 2, 6, -1, 4, 1, 8, 2 },5, new double[] { 2.2, 2.8, 2.4, 3.6, 2.8 })]
        public void findAveragesTest(int[] arr, int K, double [] expected)
        {
            var actual = SumSubarray.findAverages(arr, K);
            Assert.Equal(expected, actual);
        }
    }
}
