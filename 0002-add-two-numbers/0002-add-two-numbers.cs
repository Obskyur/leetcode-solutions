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
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        ListNode retHead = new ListNode();
        ListNode curNode = retHead;
        byte carry = 0;

        while ((l1, l2, carry) is not (null, null, 0)) {
            int sum = (l1?.val ?? 0) + (l2?.val ?? 0) + carry;
            carry = (byte)(sum / 10);
            curNode.next = new ListNode(sum % 10);
            l1 = l1?.next;
            l2 = l2?.next;
            curNode = curNode.next;
        }

        return retHead.next;
    }
}