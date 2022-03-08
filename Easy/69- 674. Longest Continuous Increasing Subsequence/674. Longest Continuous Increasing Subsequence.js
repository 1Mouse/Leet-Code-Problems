/**
 * @param {number[]} nums
 * @return {number}
 */
var findLengthOfLCIS = function (nums) {
    let LCIS = 1,
        currentMax = 1;
    for (let i = 0; i < nums.length - 1; i++)
        (nums[i + 1] > nums[i]) ? LCIS = Math.max(++currentMax, LCIS): currentMax = 1;

    return LCIS;
};
