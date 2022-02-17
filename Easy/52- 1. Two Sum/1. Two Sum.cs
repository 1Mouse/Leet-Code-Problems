public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        var map = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            if (!map.ContainsKey(target - nums[i]))
                map.TryAdd(nums[i], i);
            else
                return new int[] { map[target - nums[i]], i };
        }

        return new int[2];
    }
}