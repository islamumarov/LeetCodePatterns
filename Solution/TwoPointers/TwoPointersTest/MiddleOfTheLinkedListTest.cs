using src;
using Xunit;

namespace TwoPointersTest;

public class MiddleOfTheLinkedListTest
{
    [Fact]
    public void ShouldAllPass()
    {
        var head = Init();
        var expected = head.next.next;
        var actual = MiddleOfTheLinkedList.FindMiddle(head);
        Assert.Equal(expected, actual);
    }

    public Node Init()
    {
        var test1 = new Node(1);
        test1.next = new Node(2);
        test1.next.next = new Node(3);
        test1.next.next.next = new Node(4);
        test1.next.next.next.next = new Node(5);
        //test1.next.next.next.next.next = new Node(6);
        return test1;

    }
}