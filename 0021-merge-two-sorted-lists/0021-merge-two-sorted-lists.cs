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
    public ListNode MergeTwoLists(ListNode list1, ListNode list2) {
        ListNode p1 = list1, 
            p2 = list2,
            retHead = new ListNode(), 
            curNode = retHead;
        
        while (p1 != null && p2 != null) {
            if (p1.val < p2.val) {
                curNode.next = p1;
                p1 = p1.next;
            }
            else {
                curNode.next = p2;
                p2 = p2.next;
            }
            curNode = curNode.next;
        }
        
        curNode.next = p1 ?? p2;
        
        return retHead.next;
    }
}