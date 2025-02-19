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
    public TreeNode InvertTree(TreeNode root) {
        Mirror(root);
        return root;
    }

    public void Mirror(TreeNode node)
    {
        if (node is null)
            return;
        var tmp = node.left;
        node.left = node.right;
        node.right = tmp;
        Mirror(node.left);
        Mirror(node.right);
    }
}
