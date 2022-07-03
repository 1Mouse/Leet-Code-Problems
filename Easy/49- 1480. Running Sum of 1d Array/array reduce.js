/**
 * @param {number[]} nums
 * @return {number[]}
 */
var runningSum = nums => {
    nums.reduce((accumulator, _, i, arr) => arr[i] += accumulator)
    return nums
};
