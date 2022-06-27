using src;
using Xunit;

namespace ReverseLinkedListTests;

public class ReverseTest
{
    [Fact]
    public void reverse()
    {
        // arrange
        var arr = new int[] { 2, 4, 6, 8, 10 };
        int[] arr2 = new int[arr.Length];
        Array.Copy(arr,arr2,arr.Length);
        Array.Reverse(arr2);
        // act
        var list1 = Init(arr);
        var expected = Init(arr2);
        var  actual = ReverseLinkedList.reverse(list1);
        // Assert
        
        Assert.Equal(expected.value,actual.value);
    }

    [Fact]
    public void HashCucleTest()
    {
        //var list = new int[] { 3, 2, 0, -4 };
        ListNode list = new ListNode(3);
        var s = list.next = new ListNode(2);
        list.next.next = new ListNode(0);
        var d = list.next.next.next = new ListNode(-4);
        d.next = s;
        LinkedListCycle.HasCycle(list);

    }

    public ListNode Init(int[] arr)
    {
        ListNode head = new ListNode(arr[0]);
        var node = head;
        foreach (var i in arr[1..arr.Length])
        {
            node.next = new ListNode(i);
            node = node.next;
        }

        node.next = null;
        return head;
    }
}