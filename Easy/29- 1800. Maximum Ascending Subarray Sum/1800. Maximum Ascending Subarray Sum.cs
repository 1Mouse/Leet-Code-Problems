public class Solution
{
    public int MaxAscendingSum(int[] nums)
    {
        int sum = nums[0];
        int maxSum = nums[0];

        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] > nums[i - 1])
            {
                sum += nums[i];
            }
            else
            {
                sum = nums[i];
            }
            maxSum = Math.Max(sum, maxSum);
        }
        return maxSum;
    }
}