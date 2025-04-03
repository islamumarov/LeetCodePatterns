namespace Heap;

public class TopKFrequentElements
{
    public static int[] TopKFrequent(int[] nums, int k) {
        var frequentNums = nums.GroupBy(x => x).ToDictionary(x => x.Key, x => x.Count());

        var pq = new PriorityQueue<int, int>(comparer: Comparer<int>.Create((x, y) => x < y ? 1 : -1));
        foreach (var keyValuePair in frequentNums)
        {
            pq.Enqueue(keyValuePair.Key, keyValuePair.Value);
        }
        var result = new int[k];

        for (int i = 0; i < k; i++)
        {
            result[i] = pq.Dequeue();
        }
        
        return result;
    }
}