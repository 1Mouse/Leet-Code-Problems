/**
 * @param {number[]} nums
 * @return {void} Do not return anything, modify nums in-place instead.
 */
//https://leetcode.com/problems/move-zeroes/discuss/172432/THE-EASIEST-but-UNUSUAL-snowball-JAVA-solution-BEATS-100-(O(n))-%2B-clear-explanation
var moveZeroes = function (nums) {
    let snowBallSize = 0;
    for (let i = 0; i < nums.length; i++) {
        if (nums[i] === 0) {
            snowBallSize++;
        } else if (snowBallSize > 0) {
            nums[i - snowBallSize] = nums[i];
            nums[i] = 0;
        }
    }
};
