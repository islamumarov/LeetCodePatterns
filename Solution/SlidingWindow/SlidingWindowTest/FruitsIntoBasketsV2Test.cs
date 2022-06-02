using SlidingWindow;
using Xunit;

namespace SlidingWindowTest;

public class FruitsIntoBasketsV2Test
{ 
    [Theory]
    [InlineData(new int[]{1,2,3,2,2},4)]
    [InlineData(new int[] {3, 3, 3, 1, 2, 1, 1, 2, 3, 3, 4 }, 5)]
    public void TotalFruitTest(int[] fruits, int expexted)
    {
        var actual = FruitsIntoBasketsV2.TotalFruit(fruits);
        Assert.Equal(expexted,actual);

    }
}