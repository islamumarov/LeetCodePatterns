using DataStructures;
using src;

namespace AnyLeetcode;
// https://leetcode.com/problems/maximum-depth-of-binary-tree/
public class MaximumDepthOfBinaryTree
{
    public static int MaxDepth(TreeNode root)
    {
        return DFS(root, 0);
    }

    public static int DFS(TreeNode root, int depth)
    {
        
        if (root == null)
            return depth;
        return Math.Max(DFS(root.left, depth + 1), DFS(root.right, depth + 1));
    }
}