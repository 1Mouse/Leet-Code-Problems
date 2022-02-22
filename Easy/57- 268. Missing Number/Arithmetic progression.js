/**
 * @param {number[]} nums
 * @return {number}
 */
var missingNumber = function (nums) {
    let sum = (nums.length * (nums.length + 1)) / 2;
    nums.forEach((element) => {
        sum -= element;
    });
    return sum;
};
