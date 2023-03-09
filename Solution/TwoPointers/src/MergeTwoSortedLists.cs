namespace src;

public class MergeTwoSortedLists
{
    public static Node MergeTwoLists(Node list1, Node list2)
    {
        var firstHead = list1;
        var secondHead = list2;
        Node result = new Node();
        Node head = result;
        while (firstHead is not null && secondHead is not null)
        {
            if (firstHead.data > secondHead.data )
            {
                result.next = secondHead;
                secondHead = secondHead.next;
            }
            else
            {
                result.next = firstHead;
                firstHead = firstHead.next;
            }
            result = result.next;
        }

        result.next = firstHead ?? secondHead;

        return head.next;
    }
}