namespace src;

public class ReverseLinkedLisII
{
    public static ListNode ReverseBetween(ListNode head, int left, int right) {
        if(head.next == null || left == right) return head;
        var node = head;
        ListNode prev = node;
        ListNode first = null;
        ListNode next = null;
        int i = 1;
        while (node != null)
        {
            if (i == left)
                first = prev;
            if (i == right)
            {
                next = node;
                break;
            }

            prev = node;
            node = node.next;
            i++;
        }

        if (next.next == null)
        {
            var tm = first.next;
            first.next = null;
            tm.next = first;
            return tm;
        }
        var cur = first;
        var last = next.next;
        next.next = null;
        prev = null;
        while (cur != null)
        {
            var tm = cur.next;
            cur.next = prev;
            prev = cur;
            cur = tm;
        }

        first.next.next = last;
        first.next = prev;
        return head;
    }
}