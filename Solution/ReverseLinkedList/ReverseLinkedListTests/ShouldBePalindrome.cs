using src;
using Xunit;

namespace ReverseLinkedListTests;

public class ShouldBePalindrome
{
    [Fact]
    public void IsPalindromeTest()
    {
        var head = new ListNode(1);
        head.next = new ListNode(2);
        head.next.next = new ListNode(2);
        head.next.next.next = new ListNode(1);
        var actual = PalindromeLinkedList.IsPalindrome(head);
        Assert.True(actual);
    }
}