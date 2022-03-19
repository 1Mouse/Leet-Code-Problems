// time is O(n)
// space is O(logn) since there are at most logn recursion stacks in the meantime.

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
    public TreeNode SortedArrayToBST(int[] nums)
    {
        TreeNode head = helper(nums, 0, nums.Length - 1);
        return head;
    }

    private TreeNode helper(int[] nums, int l, int r)
    {
        if (l > r)
            return null;

        int mid = l + (r - l) / 2;
        TreeNode current = new TreeNode(nums[mid]);
        current.left = helper(nums, l, mid - 1);
        current.right = helper(nums, mid + 1, r);

        return current;
    }
}