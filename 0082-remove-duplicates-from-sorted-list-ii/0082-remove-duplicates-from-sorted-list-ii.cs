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
    public ListNode DeleteDuplicates(ListNode head) {
        var retHead = new ListNode(Int32.MinValue, head);
        ListNode nodeToRemoveFrom = retHead;
        ListNode curNode = head;

        while (curNode is not null && curNode.next is not null) {
            int curVal = curNode.val;
            var tempNode = curNode;

            while (tempNode.next is not null && tempNode.next.val.Equals(curVal))
                tempNode = tempNode.next;
            
            if (curNode != tempNode) {
                nodeToRemoveFrom.next = tempNode.next;
                curNode = tempNode.next;
            }
            else {
                nodeToRemoveFrom = curNode;
                curNode = curNode.next;
            }
        }
        return retHead.next;
    }
}