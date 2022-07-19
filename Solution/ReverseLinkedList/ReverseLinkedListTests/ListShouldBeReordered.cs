using In_Place_Reversal_LinkedList;
using src;
using Xunit;
using Xunit.Abstractions;

namespace ReverseLinkedListTests;

public class ListShouldBeReordered
{
    private readonly ITestOutputHelper _testOutputHelper;

    public ListShouldBeReordered(ITestOutputHelper testOutputHelper)
    {
        _testOutputHelper = testOutputHelper;
    }

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
       // ReorderList.ReorderListNode(list);

       var node = OddEvenLinkedList.OddEvenList(list); // list;
        while (node != null)
        {
            _testOutputHelper.WriteLine(node.value.ToString());
            node = node.next;
        }

    }
}