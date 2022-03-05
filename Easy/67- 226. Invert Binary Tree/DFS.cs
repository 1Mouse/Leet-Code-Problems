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
public class Solution
{
    //time: O(n) we traverse each node
    //space: o(log n) = height of a tree o(H) , o(n) worst case if a skew tree
    public TreeNode InvertTree(TreeNode root)
    {
        if (root == null)
            return null;
        TreeNode Templeft = root.left;
        root.left = InvertTree(root.right);
        root.right = InvertTree(Templeft);
        return root;
    }
}