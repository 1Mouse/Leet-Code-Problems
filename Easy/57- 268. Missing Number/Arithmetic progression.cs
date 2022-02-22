public class Solution
{
    public int MissingNumber(int[] nums)
    {
        // O(1) maths law to get sum of values from 0 to n
        int sum = nums.Length * (nums.Length + 1) / 2;

        for (int i = 0; i < nums.Length; i++)
        {
            // subtract a value at each iteration
            sum -= nums[i];
        }

        // we end up with only the missing value
        return sum;
    }
}