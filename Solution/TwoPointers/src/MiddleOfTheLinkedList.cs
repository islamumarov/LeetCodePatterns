namespace src;

public class MiddleOfTheLinkedList
{
    public static Node FindMiddle(Node head)
    {
        var fast = head;
        var slow = head;
        var prev = head;
        while (fast != null && fast.next != null)
        {
            prev = slow;
            slow = slow.next;
            fast = fast.next.next;
        }

        prev.next = slow.next;
        slow.next = null;
        
        return head;
    }
}