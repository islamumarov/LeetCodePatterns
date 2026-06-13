namespace Graphs;

public class CourseSchedule
{
    // topological sort
    public static bool CanFinish(int numCourses, int[][] prerequisites)
    {
        if (prerequisites.Length == 0) return true;
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
        
        var queue = new Queue<int>();
        for (int i = 0; i < sources.Length; i++)
        {
            if (sources[i] == 0)
                queue.Enqueue(i);
        }
        
        while (queue.Count > 0)
        {
            var node = queue.Dequeue();
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

        return numCourses == 0;
    }
    
    
    
    /////////
    
    public class Solution {
        private const int Unvisited = 0;
        private const int InProgress = 1;
        private const int Completed = 2;

        public bool CanFinish(int numCourses, int[][] prerequisites)
        {
            var adj = CreateAdjacencyList(numCourses, prerequisites);
            var state = new int[numCourses];
            for (int i = 0; i < numCourses; i++)
            {
                if (DetectLoop(i, adj, state)) return false;
            }
            return true;
        }


        public bool DetectLoop(int start, List<int>[] adj, int[] state)
        {
            if (state[start] == InProgress) return true;
            if (state[start] == Completed) return false;
            if (adj[start] == null) { state[start] = Completed; return false; }
            state[start] = InProgress;
            foreach (int i in adj[start])
            {
                if (DetectLoop(i, adj, state)) return true;
            }
            state[start] = Completed;
            return false;
        }

        public List<int>[] CreateAdjacencyList(int numCourses, int[][] prerequisities)
        {
            var adj = new List<int>[numCourses];
            foreach (var p in prerequisities)
            {
                adj[p[1]].Add(p[0]);
            }
            return adj;
        }
    }
}