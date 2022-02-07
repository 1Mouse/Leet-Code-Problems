public class Solution
{
    public int KthSmallest(TreeNode root, int k)
    {
        List<int> list = new List<int>();
        TreeToList(root, list, k);
        return list[k - 1];
    }

    public void TreeToList(TreeNode root, List<int> list, int k)
    {
        if (root != null)
        {
            TreeToList(root.left, list, k);
            list.Add(root.val);
            if (list.Count == k)
                return;
            TreeToList(root.right, list, k);
        }
    }
}