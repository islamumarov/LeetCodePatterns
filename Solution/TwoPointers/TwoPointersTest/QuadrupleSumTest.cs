using src;
using Xunit;

namespace TwoPointersTest;

public class QuadrupleSumTest
{
    [Fact]
    public void AllShouldPass()
    {
        var nums0 = new[] { 1000000000, 1000000000, 1000000000, 1000000000 };
        var target0 = -294967296;
        var actual = QuadrupleSumToTarget.SearchQuadruple(nums0, target0);
        var expected = new List<IList<int>>();
        Assert.Equal(expected, actual);
        var nums1 = new[] { 2, 0, -1, 1, -2, 2 };
        var target1 = 2;
        var expected1 = new List<IList<int>>() { new List<int>(){ -2, 0, 2, 2 }, new List<int>(){ -1, 0, 1, 2 } };
        var actual1 = QuadrupleSumToTarget.SearchQuadruple(nums1, target1);
        var nums2 = new[] { 4, 1, 2, -1, 1, -3 };
        var target2 = 1;
        var expected2 = new List<IList<int>>() { new List<int>(){ -3, -1, 1, 4 }, new List<int>(){ -3, 1, 1, 2 } };
        var actual2 = QuadrupleSumToTarget.SearchQuadruple(nums2, target2);
        Assert.Equal(expected1, actual1);
        Assert.Equal(expected2, actual2);
    }
}