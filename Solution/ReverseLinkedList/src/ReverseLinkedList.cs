namespace src;

public class ReverseLinkedList
{
    public static ListNode reverse(ListNode head)
    {
        var current = head;
        ListNode tmp = null;
        ListNode prev = null;
        while (current.next != null)
        {
            tmp = current.next;
            current.next = prev;
            prev = current;
            current = tmp;

        }

        current.next = prev;
        return current;

    }
}