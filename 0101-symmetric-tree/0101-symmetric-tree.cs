/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    public bool IsSymmetric(TreeNode root) =>
        IsSymmetric(root?.left, root?.right);

    private bool IsSymmetric(TreeNode left, TreeNode right) {
        if (left is null || right is null)
            return left == right;
        if (!left.val.Equals(right.val))
            return false;
        return IsSymmetric(left.left, right.right) && IsSymmetric(left.right, right.left);
    }
}