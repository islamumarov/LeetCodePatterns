namespace DFS;

public class TreeNode(int val, TreeNode left = null, TreeNode right = null)
{
    public int val { get; set; } = val;
    public TreeNode left { get; set; } = left;
    public TreeNode right
    {
        get;
        set;
    } = right;
}
public class IsTheSameTree
{
    public static bool IsSameTree(TreeNode p, TreeNode q)
    {
        var check = (TreeNode? p1, TreeNode? q1) => p1?.val == q1?.val;
        
        var dequeue = new Queue<(TreeNode?,TreeNode?)>();
        dequeue.Enqueue((p, q));

        while (dequeue.Count > 0)
        {
            var (p2, q2) = dequeue.Dequeue();
            if(!check(p2, q2)) return false;

            if (p2 is not null)
            {
                dequeue.Enqueue((p2?.left, q2?.left));
                dequeue.Enqueue((p2?.right, q2?.right));
            }
        }
        
        return true;
    }
}
