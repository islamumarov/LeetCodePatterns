using src;
using Xunit;

namespace TwoPointersTest;

public class MergeTwoSortedListsTest
{
    [Fact]
    public void AllTestShouldPass()
    {
        int[] expected = new[] { 1, 1, 2, 3, 4, 4 };
        var root1 = new Node(1, new Node(2));
        root1.next.next = new Node(4);
        var root2 = new Node(1, new Node(3));
        root2.next.next = new Node(4);
        var res = MergeTwoSortedLists.MergeTwoLists(root1, root2);
        int[] actual = new int[expected.Length];
        for (int i = 0; i < actual.Length; i++)
        {
            actual[i] = res.data;
            res = res.next;
        }
        Assert.Equal(expected, actual);
    }
}