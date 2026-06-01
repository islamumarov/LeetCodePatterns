namespace LeetCode.Arrays;

public class SingleThreadedCpu
{
    public static int[] GetOrder(int[][] tasks)
    {
        var queue = new PriorityQueue<int, int>();
        for (int i = 0; i < tasks.Length; i++)
        {
            queue.Enqueue(i, tasks[i][1] - tasks[i][0]);
        }
        
        var arr = new int[tasks.Length];
        int j = 0;
        while (queue.Count > 0)
        {
            var taskIndex = queue.Dequeue();
            arr[taskIndex] = taskIndex;
            j++;
        }

        return arr;
    }
}
