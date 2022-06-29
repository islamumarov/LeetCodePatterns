using src;
using Xunit;

namespace ReverseLinkedListTests;

public class ListShouldBeReordered
{
    [Fact]
    public void ReorderListNodeTest()
    {
        //init
        var list = new ListNode(1)
        {
            next = new ListNode(2)
            {
                next = new ListNode(3)
                {
                    next = new ListNode(4)
                    {
                        next = new ListNode(5)
                    }
                }
            }
        };
        // act
        ReorderList.ReorderListNode(list);
        var node = list;
        while (node != null)
        {
            Console.WriteLine(node.value);
            node = node.next;
        }

    }
}