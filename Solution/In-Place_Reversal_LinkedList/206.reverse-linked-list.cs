/*
 * @lc app=leetcode id=206 lang=csharp
 *
 * [206] Reverse Linked List
 */

// @lc code=start

// Definition for singly-linked list.
namespace In_Place_Reversal_LinkedList.reverse_LinkedList;
public class ListNode {
    public int val;
    public ListNode next;
    public ListNode(int val=0, ListNode next=null) {
        this.val = val;
        this.next = next;
    }
}

public class Solution {
    public static ListNode ReverseList(ListNode head) {
        if (head == null) return head;

        ListNode current = null;
        ListNode prev = head;
        ListNode next = null;

        while (prev != null)
        {
            next = prev.next;
            prev.next = current;
            current = prev;
            prev = next;
        }
        return current;
    }
}
// @lc code=end

