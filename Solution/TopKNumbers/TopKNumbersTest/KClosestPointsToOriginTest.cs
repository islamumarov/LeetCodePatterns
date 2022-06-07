using src;
using Xunit;

namespace TopKNumbersTest;

public class KClosestPointsToOriginTest
{
    [Fact]
    public void KClosest()
    {
        int[,] point1 = new int[,] { { 1, 3 }, { -2, 2 } };
        int k1 = 1;
        var expected = new int[,] { { -2, 2 } };
        var actual = KClosestPointsToOrigin.KClosest(point1, k: k1);
        Assert.Equal(expected,actual);
    }
}