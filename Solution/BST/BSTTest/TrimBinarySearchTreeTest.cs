using DataStructures;
using src;
using Xunit;

namespace BSTTest;

public class TrimBinarySearchTreeTest
{
    [Fact]
    public void TrimBSTTest()
    {
        int[] arr = new[] { 3, 0, 4, 2, 1 };
        TreeNode root = new TreeNode();
        root.val = arr[0];
        TreeNode node = root;
        for (var i = 1; i < arr.Length; i++)
        {
            Fill(arr[i], node);
        }
        var acctual = TrimBinarySearchTree.TrimBST(root, 1, 3);
        
    }

    private TreeNode Fill(int v, TreeNode node)
    {
        if (node == null)
        {
            node = new TreeNode(v);
            return node;
        }
        if (v < node.val)
        {
            node.left = Fill(v, node.left);
        }
        else if(v > node.val)
        {
            node.right = Fill(v, node.right);
        }

        return node;
    }
}