namespace src;

public class LinkedListCycleII
{
    public static ListNode FindCircleStart(ListNode head)
    {
        var (fast, slow) = (head, head);
        var len = 0;

        while (fast is not null && fast.next is not null )
        {
            slow = slow.next;
            fast = fast.next.next;
            if (slow == fast)
            {
                len = FindLen(fast);
                break;
            }
        }

        return len > 0 ? FindStart(head, len) : null;
    }


    private static ListNode FindStart(ListNode head, int len)
    {
        var (first, sec) = (head, head);

        while (len > 0)
        {
            first = first.next;
            len--;
        }

        while (first != sec)
        {
            first = first.next;
            sec = sec.next;
        }

        return first;
    }
    private static int FindLen(ListNode head)
    {
        int len = 0;
        var fast = head;
        while(true)
        {
            fast = fast.next;
            len++;
            
            if(fast == head)
                break;
        }

        return len;
    }
}