using AnyLeetcode;
using DataStructures;
using Xunit;

namespace OtherTest;

public class MaximumDepthOfBinaryTreeTest
{
    [Fact]
    public void AllShouldPass()
    {
        var root = new TreeNode(3);
        root.left = new TreeNode(9);
        root.right = new TreeNode(20, new TreeNode(15), new TreeNode(7));

        var root2 = new TreeNode(1, null, new TreeNode(2));
        var actual = MaximumDepthOfBinaryTree.MaxDepth(root);
        var actual2 = MaximumDepthOfBinaryTree.MaxDepth(root2);
        //Assert.Equal(3, actual);
        Assert.Equal(2, actual2);
    }
    
}