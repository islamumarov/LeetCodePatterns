namespace src;

public class LinkedListCycle
{
    public static bool HasCycle(ListNode head)
    {
        if (head == null || head.next == null) return false;
        ListNode slow = head;
        ListNode fast = head;
        while (fast is { next: { } })
        {
            fast = fast.next.next;
            slow = slow.next;
            if (fast == slow)
                return true;
        }
        return false;
    }
}