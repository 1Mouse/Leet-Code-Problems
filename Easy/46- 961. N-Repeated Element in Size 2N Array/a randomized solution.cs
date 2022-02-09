    public class Solution
    {
        //This is a solution just for fun, not for interview.
        //Instead of compare from left to right,
        //we can compare in random order.

        //Random pick two numbers.
        //Return if same.

        //50% to get the right number.
        //Each turn, 25% to get two right numbers.
        //Return the result in average 4 turns.
        //Time complexity amortized O(4), space O(1)
        public int RepeatedNTimes(int[] nums)
        {
            int rand1 = 0, rand2 = 0;
            while (rand1 == rand2 || nums[rand1] != nums[rand2])
            {
                rand1 = new Random().Next(0, nums.Length);//0 <= rand1 < nums.length
                rand2 = new Random().Next(0, nums.Length);
            }
            return nums[rand1];

        }
    }