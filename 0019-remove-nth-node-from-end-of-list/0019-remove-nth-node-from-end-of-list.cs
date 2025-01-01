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
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
        ListNode retHead = new(0, head);
        ListNode curNode = retHead;
        ListNode nodeBeforeRmv = retHead;
        for (; n > 0; n--)
            curNode = curNode.next;
        
        while (curNode?.next is not null) {
            curNode = curNode.next;
            nodeBeforeRmv = nodeBeforeRmv.next;
        }
        nodeBeforeRmv.next = nodeBeforeRmv.next?.next;
        return retHead.next;
    }
}