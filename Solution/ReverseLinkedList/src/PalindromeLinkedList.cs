namespace src;

public class PalindromeLinkedList
{
    public static bool IsPalindrome(ListNode head)
    {
        Dictionary<int, int> listNPos = new Dictionary<int, int>();
        var node = head;
        int n = 0;

        while (node != null)
        {
            listNPos.Add(n, node.value);
            n++;
            node = node.next;
        }

        for (int i = 0; i < n/2; i++)
        {
            if (listNPos[i] != listNPos[n - i-1])
                return false;
        }

        return true;
    }
}