namespace DataStructures;

public class TreeNode
{
    public int Val { get; set; }
    public TreeNode? Left { get; set; }
    public TreeNode? Right { get; set; }

    public TreeNode(int x)
    {
        Val = x;
    }

    public void Build(List<int?> nums, int i, TreeNode cur)
    {
        var parent = i;
        var left = parent * 2 + 1;
        var right = parent * 2 + 2;
        cur = new TreeNode(nums[i].Value);
        if (left < nums.Count && nums[left] != null)
        {
            Build(nums, left, cur.Left);
        }
        if (right < nums.Count && nums[right] != null)
        {
            Build(nums, left, cur.Right);
        }
    }
}
