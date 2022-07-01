using In_Place_Reversal_LinkedList.reverse_LinkedList;

namespace In_Place_Reversal_LinkedList;

public class OddEvenLinkedList
{
    public static ListNode OddEvenList(ListNode head)
    {
        ListNode f = head;
        ListNode s = head.next;
        while (s is { next: { } })
        {
            f.next = s.next;
            f = f.next;
            s.next = s.next.next;
            s = s.next;
        }

        f.next = head.next;
        return head;
    }
}