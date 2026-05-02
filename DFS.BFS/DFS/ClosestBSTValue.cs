namespace DFS;

public class ClosestBSTValue
{
    public static IList<int> ClosestKValues(TreeNode root, double target, int k)
    {
        var pq = new PriorityQueue<int, double>();
        var deq = new Queue<TreeNode>();
        deq.Enqueue(root);
        
        while (deq.Count > 0)
        {
            root = deq.Dequeue();
            pq.Enqueue(root.val, Math.Abs(root.val - target));

            if (root.left != null)
            {
                deq.Enqueue(root.left);
            }
            if (root.right != null)
            {
                deq.Enqueue(root.right);
            }
        }

        var res = new List<int>();
        while (k != 0)
        {
            res.Add(pq.Dequeue());
            k--;
        }

        return res;
    }
}

