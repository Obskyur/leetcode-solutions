/*
// Definition for a Node.
public class Node {
    public int val;
    public Node next;
    public Node random;
    
    public Node(int _val) {
        val = _val;
        next = null;
        random = null;
    }
}
*/

public class Solution {
    public Node CopyRandomList(Node head) {
        if (head is null) 
            return null;
        
        var oldToNew = new Dictionary<Node, Node>();
        Node curNode = head;
        while (curNode is not null) {
            oldToNew.Add(curNode, new Node(curNode.val));
            curNode = curNode.next;
        }
        curNode = head;
        while (curNode is not null) {
            oldToNew[curNode].next = curNode.next is not null ? oldToNew[curNode.next] : null;
            oldToNew[curNode].random = curNode.random is not null ? oldToNew[curNode.random] : null;
            curNode = curNode.next;
        }
        return oldToNew[head];
    }
}