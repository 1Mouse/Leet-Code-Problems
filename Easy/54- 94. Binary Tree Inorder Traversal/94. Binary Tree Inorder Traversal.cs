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
Time complexity: O(n)O(n)

The time complexity is O(n)O(n) because the recursive function is T(n) = 2 \cdot T(n/2)+1T(n)=2⋅T(n/2)+1.
Space complexity: O(n)O(n)

The worst case space required is O(n)O(n), and in the average case it's O(\log n)O(logn) where nn is number of nodes.
*/
public class Solution
{
    public IList<int> InorderTraversal(TreeNode root)
    {
        var res = new List<int>();
        helper(root, res);
        return res;
    }
    private void helper(TreeNode root, List<int> res)
    {
        if (root != null)
        {
            helper(root.left, res);
            res.Add(root.val);
            helper(root.right, res);
        }
    }
}