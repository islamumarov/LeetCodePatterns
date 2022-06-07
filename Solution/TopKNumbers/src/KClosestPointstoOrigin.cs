namespace src;

public class KClosestPointsToOrigin
{
    public static int[,] KClosest(int[,] points, int k)
    {
        PriorityQueue<int, int> queue = new PriorityQueue<int, int>();
        int n = points.Length/2;
        for (int i = 0; i < n; i++)
        {
            var prior = points[i, 0] * points[i,0] + points[i, 1]*points[i,1];
            queue.Enqueue(i,prior);
        }

        var ds = new int[k,2];
        for (int i = 0; i < ds.Length; i++)
        {
            var tmp = queue.Peek();
            ds[i, 0] = points[tmp, 0];
            ds[i, 1] = points[tmp,1];
        }

        return ds;
    }
}