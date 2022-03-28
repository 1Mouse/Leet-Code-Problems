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
    // Iterative DFS
    // O(n) time , O(n) space
    public int RangeSumBST(TreeNode root, int low, int high)
    {
        if (root == null) return 0;

        var s = new Stack<TreeNode>();
        int res = 0;
        s.Push(root);

        while (s.Count != 0)
        {
            var curr = s.Pop();
            if (curr == null) continue;

            s.Push(curr.left);
            s.Push(curr.right);
            if (curr.val >= low && curr.val <= high)
                res += curr.val;

        }

        return res;
    }
}