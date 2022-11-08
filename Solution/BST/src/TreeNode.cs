namespace src;

public class TreeNode
{
    public int val;
    public TreeNode left;
    public TreeNode right;

    public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
    {
        this.val = val;
        this.left = left;
        this.right = right;
    }
    public void FillNode(TreeNode head, int val)
    {
        TreeNode nodePrev = head;
        while (head != null)
        {
            nodePrev = head;
            if (val > head.val)
            {
                head = head.right;
            }
            if (val < head.val)
                head = head.left;
        }
        if (nodePrev.val > val)
            nodePrev.left = new TreeNode(val);
        else
            nodePrev.right = new TreeNode(val);
    }
}