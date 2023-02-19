using src;
using Xunit;

namespace TwoPointersTest;

public class TripletSumToZeroTest
{
    [Fact]
    public void AllShouldPass()
    {
        var test1 = new[] { -3, 0, 1, 2, -1, 1, -2 };
        var test2 = new[] { -5, 2, -1, -2, 3 };
        var expected1 = new List<IList<int>>()
        {
            new List<int>() { -3, 1, 2 }, 
            new List<int>() { -2, 0, 2 }, 
            new List<int>() { -2, 1, 1 },
            new List<int>() { -1, 0, 1 }
        };
        var expected2 = new List<IList<int>>()
        {
            new List<int>() { -5, 2, 3 },
            new List<int>() { -2, -1, 3 }
        };
        var actual1 = TripletSumToZero.FindTriplets(test1);
        var actual2 = TripletSumToZero.FindTriplets(test2);
        Assert.Equal(expected1, actual1);
        Assert.Equal(expected2, actual2);
    }
}