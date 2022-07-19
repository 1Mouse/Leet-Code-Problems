/**
 * @param {number[]} nums
 * @return {number[]}
 */
var productExceptSelf = function (nums) {
    let totalProduct = nums[0];
    let totalProductNoZeros;
    totalProductNoZeros = (nums[0] === 0) ? 1 : nums[0];
    let countZeros;
    countZeros = (nums[0] === 0) ? 1 : 0;
    for (let i = 1; i < nums.length; i++) {
        totalProduct *= nums[i];
        if (nums[i] !== 0) {
            totalProductNoZeros *= nums[i];
        }
        else {
            countZeros++;
        }
    }

    let ans = []
    for (let i = 0; i < nums.length; i++) {
        if (nums[i] !== 0) {
            ans[i] = totalProduct / nums[i];
        }
        else if (countZeros >= 2) {
            ans[i] = 0;
        }
        else {
            ans[i] = totalProductNoZeros;
        }
    }

    return ans;
};