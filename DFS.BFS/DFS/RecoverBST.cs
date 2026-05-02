namespace DFS;

public class RecoverBST
{
    private static void InOrder(TreeNode root, List<int> arr)
    {
        if (root is null)
        {
            return;
        }
        
        InOrder(root.left, arr);
        arr.Add(root.val);
        InOrder(root.right, arr);
    }

    private static (int?, int?) GetSwapValues(List<int> arr)
    {
         (int? x, int? y) = (null, null);
        for (int i = 0; i < arr.Count-1; i++)
        {
            if (arr[i + 1] < arr[i])
            {
                y = arr[i + 1];
                if (x is null) x = arr[i];
                else break;
            }
        }

        return (x, y);
    }

    private static void Recover(TreeNode? root, int count, int x, int y)
    {
        if (root != null)
        {
            if (root.val == x || root.val == y)
            {
                root.val = root.val == x ? y : x;
                count -= 1;
                if(count == 0) return;
            } 
        }
    }
    public  static void RecoverTree(TreeNode root)
    {
        var arr = new List<int>();
        InOrder(root, arr);
        var (x, y) = GetSwapValues(arr);
        
        Recover(root, 2, x.Value!, y.Value!);
    }
}
