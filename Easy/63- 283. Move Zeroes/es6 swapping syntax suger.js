/**
 * @param {number[]} nums
 * @return {void} Do not return anything, modify nums in-place instead.
 */
var moveZeroes = function (nums) {
    let insertPosition = 0;

    // swapping values with zeros by tracking the index of the last injected value by insertPosition pointer
    for (let i = 0; i < nums.length; i++) {
        if (nums[i] !== 0) {
            [nums[i], nums[insertPosition++]] = [nums[insertPosition], nums[i]];
            //if you are confused about the ++ just don't add it in the swap and
            //increment it in the next line:
            //insertPosition++;
        }
    }
};
