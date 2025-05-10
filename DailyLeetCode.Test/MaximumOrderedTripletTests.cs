namespace DailyLeetCode.Test;

public class MaximumOrderedTripletTests
{
    [Theory]
    //[InlineData(new int[]{12,6,1,2,7}, 77)]
   // [InlineData(new int[]{2,3,1}, 0)]
    [InlineData(new int[]{1000000,1,1000000}, 999999000000)]
    public void AllShouldPass_MaximumTripletValue(int[] nums, long expected)
    {
        var actual = MaximumOrderedTriplet.MaximumTripletValue_MaxQueue(nums);
        
        Assert.Equal(expected, actual);
    }
}