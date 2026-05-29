using Sortings;

namespace SortingsTests;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        var arr = new int[]
        {
            9,
            3,
            5,
            6,
            7,
            3,
            2,
            1,
            0
        };
        var expected = arr.Order().ToArray();
        SortingAlgos.Insertions(arr);
        Assert.Equal(expected, arr);
    }
}
