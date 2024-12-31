/**
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
public class Solution {
    public bool HasCycle(ListNode head) {
        var visitedNodes = new HashSet<ListNode>();
        ListNode curNode = head;
        while (curNode != null) {
            if (visitedNodes.Contains(curNode.next))
                return true;
            visitedNodes.Add(curNode);
            curNode = curNode.next;
        }
        return false;
    }
}