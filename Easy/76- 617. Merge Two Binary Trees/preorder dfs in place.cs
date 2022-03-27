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
    /*
    Time complexity : O(n). A total of n nodes need to be traversed. Here, n represents the minimum number of nodes from the two given trees.

    Space complexity : O(log n) The depth of the recursion tree. it can go up to O(n) in the case of a skewed tree.In average case, depth will be O(log n).
    */
    public TreeNode MergeTrees(TreeNode t1, TreeNode t2) {
    // preorder dfs in place modification
    if(t1==null)
        return t2;
    if(t2==null)
        return t1;

    t1.val+=t2.val;

    t1.left=MergeTrees(t1.left,t2.left);
    t1.right=MergeTrees(t1.right,t2.right);

    return t1;
    }
}