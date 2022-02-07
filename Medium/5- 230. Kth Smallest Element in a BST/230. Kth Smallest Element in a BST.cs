public class Solution
{
    List<int> list = new List<int>();
    public int KthSmallest(TreeNode root, int k)
    {
        TreeToList(root);
        return list[k - 1];
    }

    public void TreeToList(TreeNode root)
    {
        if (root != null)
        {
            TreeToList(root.left);
            list.Add(root.val);
            TreeToList(root.right);
        }
    }
}