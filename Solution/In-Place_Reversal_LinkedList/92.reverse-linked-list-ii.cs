/*
 * @lc app=leetcode id=92 lang=csharp
 *
 * [92] Reverse Linked List II
 */

// @lc code=start
/*
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
namespace In_Place_Reversal_LinkedList.reverse_LinkedList;
public class ReverseLinkedList {
    public ListNode ReverseBetween(ListNode head, int left, int right) {
        if(head.next == null) return head;
        ListNode p=null;
        ListNode pPrev = null;
        ListNode qNext = null;
        ListNode q = null;
        ListNode node = head;
        while(head.next != null)
        {
            if(head.val == left)
            {
                pPrev = head;
                p = head.next;
            }
            if(head.val == right)
            {
                q = head;
                qNext = q.next;
                break;
            }
            head = head.next;
        }
        ListNode cur = null;
        while(p != q)
        {
            var next = p.next;
            p.next = cur;
            cur = p;
            p = next;
        }
        q.next = pPrev;
        p.next = qNext;

        return node;

    }

}
// @lc code=end

