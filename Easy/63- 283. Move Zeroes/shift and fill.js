/**
 * @param {number[]} nums
 * @return {void} Do not return anything, modify nums in-place instead.
 */
var moveZeroes = function (nums) {
    let insertPosition = 0;

    // Shift non-zero values as to the beginning of the array
    for (let num of nums) {
        if (num !== 0) nums[insertPosition++] = num;
    }

    // Fill remaining space with zeros
    while (insertPosition < nums.length) {
        nums[insertPosition++] = 0;
    }
};
