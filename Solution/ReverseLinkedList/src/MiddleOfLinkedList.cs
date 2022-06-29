namespace src;

public class MiddleOfLinkedList
{
    public static ListNode MiddleNode(ListNode head)
    {
        ListNode slow = head;
        ListNode fast = head.next;
        while (fast != null)
        {
            slow = slow.next;
            if (fast.next == null) break;
            fast = fast.next.next;
        }

        return slow;
    }
}