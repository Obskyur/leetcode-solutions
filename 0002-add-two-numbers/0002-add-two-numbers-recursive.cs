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
        var retHead = new ListNode();
        ListNode p1 = l1, 
            p2 = l2, 
            tail = retHead;
        bool carry = false;

        while (p1 != null && p2 != null) {
            int sum = p1.val + p2.val + (carry ? 1 : 0);
            if (sum >= 10) {
                carry = true;
                sum %= 10;
            }
            else
                carry = false;
            tail.next = new ListNode(sum);
            p1 = p1.next;
            p2 = p2.next;
            tail = tail.next;
        }
        var remainingNums = p1 ?? p2;
        tail.next = remainingNums;
        while (carry == true) {
            if (remainingNums == null) {
                tail.next = new ListNode(1);
                tail = tail.next;
                carry = false;
            }
            else if (remainingNums.val == 9) {
                remainingNums.val = 0;
                remainingNums = remainingNums.next;
                tail = tail.next;
            }
            else if (remainingNums.val < 9) {
                remainingNums.val += 1;
                remainingNums = remainingNums.next;
                tail = tail.next;
                carry = false;
            }
        }
        return retHead.next;
    }
}