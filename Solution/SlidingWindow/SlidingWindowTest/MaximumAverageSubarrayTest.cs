using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using SlidingWindow;

namespace SlidingWindowTest
{
    public class MaximumAverageSubarrayTest
    {
        [Theory]
        [InlineData(new int[] { 1,12,-5,-6,50,3},4,12.75000)]
        public void findAveragesTest(int[] arr, int K, double expected)
        {
            var actual = MaximumAverageSubarray.FindMaxAverage(arr, K);
            Assert.Equal(expected, actual);
        }
    }
}