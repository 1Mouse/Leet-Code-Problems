/**
 * @param {number[]} nums
 * @return {number}
 */
var pivotIndex = function (nums) {
    /*
    array:       1, 7,  3,  6,  5,  6
    prefix sum:  1, 8, 11, 17, 22, 28
    The pivot index is the index where leftSum = rightSum
    rightSum= totalSum - leftSum- currentValue
    */
    let sum = 0, leftSum = 0, rightSum = 0;
    nums.forEach(element => {
        sum += element;
    });

    for (let i = 0; i < nums.length; i++) {
        rightSum = sum - leftSum - nums[i];
        if (leftSum == rightSum) return i;
        leftSum += nums[i];
    }

    return -1;
};