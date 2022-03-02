/**
 * @param {number[]} nums
 * @param {number} target
 * @return {number}
 */
var searchInsert = function (nums, target) {
    return binarySearch(nums, target, 0, nums.length - 1);
};

function binarySearch(nums, target, l, r) {
    if (l > r) return l;

    let mid = Math.floor(l + (r - l) / 2); //to avoid overflow
    if (nums[mid] == target) return mid;
    if (nums[mid] > target) return binarySearch(nums, target, l, mid - 1);
    if (nums[mid] < target) return binarySearch(nums, target, mid + 1, r);
}
