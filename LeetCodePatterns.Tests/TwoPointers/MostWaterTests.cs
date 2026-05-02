using TwoPointers;

namespace LeetCodePatterns.Tests.TwoPointers;

public class MostWaterTests
{
    [Theory]
    [InlineData(new[]{1,8,6,2,5,4,8,3,7}, 8)]
    [InlineData(new []{1,1}, 1)]
    public void AllShouldPass_MaxArea(int[] heights, int expected)
    {
        var findMax = new FindMax(heights);
        Assert.Equal(expected, findMax.GetMaxArea());
    }
}

public class FindMax
{
    private readonly PriorityQueue<int, int> _pq = new PriorityQueue<int, int>(Comparer<int>.Create(((i, i1) => -i + i1)));
    public FindMax(int[] heights)
    {
        foreach (var height in heights)
        {
            _pq.Enqueue(height, height);
        }
    }


    public int BinSearchLeft(int[] array, int target)
    {
        var left = 0;
        var right = array.Length - 1;
        while (left <= right)
        {
            var mid = left + (right - left) / 2;
            if (array[mid] == target)
            {
                return mid;
            }
            if (array[mid] > target)
            {
                right = mid - 1;
            }
            else
            {
                left = mid + 1;
            }
        }
        
        return array[right] - 1;
    }

    public int GetMaxArea()
    {
        return _pq.Dequeue();
    }
}



