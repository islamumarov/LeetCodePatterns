namespace Stack.Queue;

public class MedianFinder
{
    public PriorityQueue<float, float> low;
    public PriorityQueue<float, float> high;
    public MedianFinder() {
        low = new PriorityQueue<float, float>();
        high = new PriorityQueue<float, float>(comparer: Comparer<float>.Default);
    }
    
    public void AddNum(int num) {
        if (low.Count == high.Count && low.Count > 0)
        {
            var temp = low.EnqueueDequeue(num, num);
            high.Enqueue(temp, temp);
        }
        else
        {
            low.Enqueue(num, num);
        }
    }
    
    public double FindMedian() {
        if (low.Count == high.Count)
        {
            return (low.Peek() + high.Peek())/2;
        }

        return low.Peek();
    }
}

