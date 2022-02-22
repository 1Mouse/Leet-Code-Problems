// Time limit excceded
// O(n) space
// O(n log n) time
public class Solution
{
    public int MissingNumber(int[] nums)
    {
        var sortedSet = new SortedSet<int>();
        foreach (var num in nums)
        {
            sortedSet.Add(num);
        }

        for (int i = 1; i < sortedSet.Count; i++)
        {
            if (sortedSet.ElementAt(i) - sortedSet.ElementAt(i - 1) == 2)
                return sortedSet.ElementAt(i) - 1;
        }

        if (nums.Length == 1 && nums[0] == 0)
            return 1;
        else if (nums.Length == 1 && nums[0] == 1)
            return 0;
        else if (sortedSet.Contains(0))
            return nums.Length;
        else
            return 0;
    }
}