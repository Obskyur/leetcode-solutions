/**
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
public class Solution {
    public ListNode RotateRight(ListNode head, int k) {
        if (head is null)
            return head;
        
        ListNode curNode = head;
        ushort length = 1;
        
        while (curNode.next is not null) {
            length++;
            curNode = curNode.next;
        }

        curNode.next = head;
        k = length - (k % length);

        for (; k > 0; k--) {
            head = head.next;
            curNode = curNode.next;
        }
        curNode.next = null;
        return head;
    }
}