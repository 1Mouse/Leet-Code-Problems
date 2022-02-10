public class Solution
{
    public int[] FrequencySort(int[] nums)
    {
        return nums.GroupBy(key => key, _ => _)
                .OrderBy(_ => _.Count())
                .ThenByDescending(_ => _.Key)
                .SelectMany(_ => _)
                .ToArray();

    }
}