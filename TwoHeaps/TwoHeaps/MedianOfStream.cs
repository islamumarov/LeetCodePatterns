namespace TwoHeaps;


/// <summary>
/// Design a class to calculate the median of a number stream. The class should have the following two methods:
/// insertNum(int num): stores the number in the class
/// findMedian(): returns the median of all numbers inserted in the class
/// If the count of numbers inserted in the class is even, the median will be the average of the middle two numbers.
/// </summary>
public class MedianOfStream
{
    private PriorityQueue<int, int> minHeap = new();
    private PriorityQueue<int, int> maxHeap = new();

    public MedianOfStream()
    {
    }


}
