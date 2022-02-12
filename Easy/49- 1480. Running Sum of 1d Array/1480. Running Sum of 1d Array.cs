public class Solution
{
    public int[] RunningSum(int[] nums)
    {
        int prefixSum = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            prefixSum += nums[i];
            nums[i] = prefixSum;
        }
        return nums;
    }
}