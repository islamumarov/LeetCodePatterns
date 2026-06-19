namespace Stack.Queue;

public class TaskScheduler621
{
    public int LeastInterval(char[] tasks, int n)
    {
        var frequency = new int[26];
        foreach (char task in tasks)
        {
            frequency[task - 'A']++;
        }
        var pq = new PriorityQueue<int, int>();
        var res = new List<char>();
        for (var i = 0; i < frequency.Length; i++)
        {
            if (frequency[i] > 0)
            {
                pq.Enqueue(i, -frequency[i]);
            }
        }
        // Step 3: cooldown line — tasks waiting out their n-gap.
        //         each entry = (remaining count, the time it's allowed back).
        var cooldown = new Queue<(int count, int availAt)>();
        int time = 0;

        while (pq.Count > 0 || cooldown.Count > 0)
        {
            time++;
            if (pq.Count > 0)
            {
                int remaining = pq.Dequeue() - 1;
                if (remaining > 0)
                {
                    cooldown.Enqueue((remaining, time + n));
                }
            }
            // else: heap empty but cooldown not -> this interval is forced idle.

            // Step 5: if the task at the front of cooldown is eligible now, release it.
            if (cooldown.Count > 0 && cooldown.Peek().availAt == time) {
                var ready = cooldown.Dequeue();
                pq.Enqueue(ready.count, -ready.count);
            }
            
        }
        


        return time;
    }
}