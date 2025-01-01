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
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2, byte carry = 0) {
        if ((l1, l2, carry) is (null, null, 0))
            return null;
        int sum = (l1?.val ?? 0) + (l2?.val ?? 0) + carry;
        carry = (byte)(sum / 10);
        return new ListNode(sum % 10, AddTwoNumbers(l1?.next, l2?.next, carry));
    }
}