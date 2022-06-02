using SlidingWindow;
using Xunit;

namespace SlidingWindowTest;

public class FruitIntoBasketsTest
{
    [Theory]
    [InlineData(new char[] {'A', 'B', 'C', 'B', 'B', 'C'},5)]
    [InlineData(new char[]{'A', 'B', 'C', 'A', 'C'},3)]
    public void MaxCountOf2TypesTest(char[] fruits, int expected)
    {
        var actual = FruitIntoBaskets.MaxCountOf2Types(fruits);
        
        Assert.Equal(expected,actual);
    }
}