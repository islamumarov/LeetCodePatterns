using DataStructures;

namespace AnyLeetcode;

public class MinimumDistanceBetweenBSTNodes
{
    public static int MinDiffInBST(TreeNode root)
    {

        var min = Math.Min(root.val - (root.left is not null ? root.left.val : 0),
            root.val - (root.right is not null ? root.right.val : 0));
        return min;
    }
}