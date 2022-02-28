public class Solution {
        public IList<string> SummaryRanges(int[] nums)
        {
            var result = new List<string>();
            for (int i = 0; i < nums.Length; i++)
            {
                int start = nums[i];
                while (i < nums.Length - 1 && nums[i + 1] - nums[i] == 1)
                {
                    i++;
                }
                if (start != nums[i])
                    result.Add($"{start}->{nums[i]}");
                else
                    result.Add($"{start}");
            }

            return result;
        }
}