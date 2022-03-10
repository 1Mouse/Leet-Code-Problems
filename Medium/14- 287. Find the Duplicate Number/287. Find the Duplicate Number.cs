public class Solution
{
    public int FindDuplicate(int[] nums)
    {
        int sum = (nums.Length * (nums.Length - 1)) / 2;

        foreach (int num in nums)
        {
            sum -= num;
        }
        return -sum;
    }
}