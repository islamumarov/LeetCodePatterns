namespace Graphs;

public class CourseSchedule2
{
    public int[] FindOrder(int numCourses, int[][] prerequisites) {

        if(prerequisites.Length == 0) return Enumerable.Range(0, numCourses).ToArray();
        var sources = new int[numCourses];
        var graph = new Dictionary<int, List<int>>();
        var n = prerequisites.Length;
        var m = prerequisites[0].Length;

        foreach (int[] prerequisite in prerequisites)
        {
            if (!graph.ContainsKey(prerequisite[1]))
            {
                graph[prerequisite[1]] = [];
            }
            graph[prerequisite[1]].Add(prerequisite[0]);
            sources[prerequisite[0]]++;
        }
        var order = new int[numCourses];
        var queue = new Queue<int>();
        for (int i = 0; i < sources.Length; i++)
        {
            if (sources[i] == 0)
                queue.Enqueue(i);
        }
        
        int j = 0;
        while (queue.Count > 0)
        {
            var node = queue.Dequeue();
            order[j] = node;
            j++;
            numCourses--;
            if (!graph.TryGetValue(node, out List<int>? value)) continue;
            foreach (int i in value)
            {
                sources[i]--;
                if (sources[i] == 0)
                {
                    queue.Enqueue(i);
                }
            }
        }

        return numCourses == 0 ? order : [];
    }
}