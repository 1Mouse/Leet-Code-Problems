/* https://leetcode.com/problems/n-repeated-element-in-size-2n-array/discuss/208563/JavaC%2B%2BPython-O(1)-Solution

algo: sort
time complexity: O( n log(n) )
space complexity: O(1)
*/ 
public class Solution
    {
        public int RepeatedNTimes(int[] nums)
        {
            Array.Sort(nums);

            if (nums[nums.Length / 2] == nums[(nums.Length / 2) + 1])
                return nums[nums.Length / 2];
            else if (nums[(nums.Length / 2)-1] == nums[(nums.Length / 2) -2])
                return nums[(nums.Length / 2)-1];
            else if (nums[(nums.Length / 2)-1] == nums[(nums.Length / 2)])
                return nums[(nums.Length / 2)-1];

            return -1;
        }
    }
