
using src;

namespace In_Place_Reversal_LinkedList;

public class OddEvenLinkedList
{
    public static ListNode OddEvenList(ListNode head)
    {
        if (head?.next == null) return head;
        ListNode f = head;
        ListNode s = head.next;
        ListNode sPrev = head.next;
        while (s is { next: { } })
        {
            f.next = s.next;
            f = f.next;
            s.next = s.next.next;
            s = s.next;
        }

        f.next = sPrev;
        return head;
    }
}