// from leetcode solutions
// https://leetcode.com/problems/find-the-duplicate-number/solution/
// time O(n) , space O(1)

public class Solution
{
    public int FindDuplicate(int[] nums)
    {
        while (nums[0] != nums[nums[0]])
        {
            Swap(ref nums[0], ref nums[nums[0]]);
        }
        return nums[0];
    }
    private void Swap(ref int x, ref int y)
    {
        int temp = x;
        x = y;
        y = temp;
    }
}

