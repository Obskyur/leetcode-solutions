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
    Dictionary<Node, Node> oldToNewNode = new Dictionary<Node, Node>();

    public Node CopyRandomList(Node node) {
        if (node is null)
            return null;

        oldToNewNode.Add(node, new Node(node.val));
        CopyRandomList(node.next);
        oldToNewNode[node].next = 
            node.next is null 
                ? null 
                : oldToNewNode[node.next];
        oldToNewNode[node].random = 
            node.random is null 
                ? null 
                : oldToNewNode[node.random];
        return oldToNewNode[node];
    }
}