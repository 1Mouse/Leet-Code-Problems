//https://backtobackswe.com/platform/content/max-contiguous-subarray-sum/solutions
public class Solution {
    public int MaxSubArray(int[] nums) {
            int maxSoFar = nums[0];
            int maxEndingHere = nums[0];

            for (int i = 1; i < nums.Length; i++)
            {

                //Console.WriteLine($"maxEndingHere: {maxEndingHere}");
                //Console.WriteLine($"max of ({maxEndingHere+nums[i]}, {nums[i]})");
                maxEndingHere = Math.Max(maxEndingHere + nums[i], nums[i]);
                //Console.WriteLine($"------->maxEndingHere: {maxEndingHere}");
                //Console.WriteLine($"maxSoFar: {maxSoFar}");
                maxSoFar = Math.Max(maxSoFar, maxEndingHere);
                //Console.WriteLine($"------->Final maxSoFar: {maxSoFar}");
                //Console.WriteLine();
            }

            return maxSoFar;
        }
}
