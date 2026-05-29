public class ScheduleTasks
{
    public static int MinimumMachines(int[][] tasks)
    {
        Array.Sort(tasks, (a, b) => a[0].CompareTo(b[0]));
        var prev = tasks[0];
        var queue = new PriorityQueue<int[], int>();
        queue.Enqueue(prev, prev[1]);
        for (int i = 1; i < tasks.Length; i++)
        {
            var current = tasks[i];
            if (current[0] >= queue.Peek()[1])
            {
                queue.Dequeue();
            }

            queue.Enqueue(current, current[1]);
        }

        return queue.Count;
    }
}
