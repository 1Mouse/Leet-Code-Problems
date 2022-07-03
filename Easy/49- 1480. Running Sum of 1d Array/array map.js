/**
 * @param {number[]} nums
 * @return {number[]}
 */
var runningSum = function (nums) {
    let runningtotal = 0;
    return nums.map(num => runningtotal += num);
};
