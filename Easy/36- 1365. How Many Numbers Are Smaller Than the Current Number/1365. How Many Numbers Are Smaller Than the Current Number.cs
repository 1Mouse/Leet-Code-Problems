public class Solution
{
    public int[] SmallerNumbersThanCurrent(int[] nums)
    {
        int[] result = new int[nums.Length];

        // O(n)^2 naive compare the i th number to all other elements if it's bigger than them increase its counter in the 
        // result array
        for (int i = 0; i < nums.Length; i++)
            for (int j = 0; j < nums.Length; j++)
                if (nums[i] > nums[j])
                    result[i]++;

        return result;
    }
}