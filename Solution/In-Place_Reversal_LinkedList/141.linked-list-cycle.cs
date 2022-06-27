/*
 * @lc app=leetcode id=141 lang=csharp
 *
 * [141] Linked List Cycle
 */

// @lc code=start
/*
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) {
 *         val = x;
 *         next = null;
 *     }
 * }
 */
 using System.Collections.Generic;
 using In_Place_Reversal_LinkedList.reverse_LinkedList;

namespace In_Place_Reversal_LinkedList;
public class Solution {
    public bool HasCycle(ListNode head) {
        HashSet<ListNode> set = new HashSet<ListNode>();
        if (head == null) return false;
        set.Add(head);
        var node = head.next;
        while (node != null)
        {
            if (set.Contains(node))
            {
                return true;
            }
            set.Add(node);
            node = node.next;
        }
        return false;
    }
}
// @lc code=end

