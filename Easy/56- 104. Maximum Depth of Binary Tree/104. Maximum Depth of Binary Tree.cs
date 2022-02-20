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

/*
Comlexity:
TC - O(num of nodes) as we are traversing all the nodes of the tree
SC - O(1) without taking the implicit recursive stack into consideration
*/
public class Solution {
        public int MaxDepth(TreeNode root)
        {
            if (root == null)
                return 0;
            int leftDepth = MaxDepth(root.left);
            int rightDepth = MaxDepth(root.right);

            return Math.Max(leftDepth, rightDepth) + 1;
        }
}