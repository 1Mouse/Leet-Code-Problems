    public class Solution
    {
        // time: O(n^2)
        // space O(1)
        public int SubarraySum(int[] nums, int k)
        {
            int count = 0;
            for (int start = 0; start < nums.Length; start++)
            {
                int sum = 0;
                for (int end = start; end < nums.Length; end++)
                {
                    sum += nums[end];
                    count = (sum == k) ? ++count : count;
                }
            }
            return count;
        }
    }