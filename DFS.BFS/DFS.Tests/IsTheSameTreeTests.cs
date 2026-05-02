namespace DFS.Tests;

public class IsTheSameTreeTests
{
    [Fact]
    public void IsSameTree_AllShouldPass()
    {
        var root1 = new TreeNode(1, new TreeNode(2), new TreeNode(3));
        var root2 = new TreeNode(1, new TreeNode(2), new TreeNode(3));
        
        var actual = IsTheSameTree.IsSameTree(root1, root2);
        Assert.True(actual);
    }

    [Fact]
    public void IsSameTree_AllShouldFail()
    {
        var root1 = new TreeNode(1, new TreeNode(2), new TreeNode(3));
        var root2 = new TreeNode(2, new TreeNode(2), new TreeNode(3));
        var actual = IsTheSameTree.IsSameTree(root1, root2);
        Assert.False(actual);
    }
}

public class RecoverBSTreeTest
{
    [Fact]
    public void RecoverTree_AllShouldPass()
    {
        var root = new TreeNode(3, new TreeNode(1), new TreeNode(4, new TreeNode(2)));
        
        RecoverBST.RecoverTree(root);
        Assert.Equal(2, root.val);
    }
}
