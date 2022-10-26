https://www.youtube.com/watch?v=OKcrLfR-8mE&ab_channel=NeetCode

function checkSubarraySum(nums: number[], k: number): boolean {
    let sum = 0;
    let remaindersMap = new Map();
    remaindersMap.set(0, -1); // to cover cases where the first element is a multible as we want a sub array of two elements , try this test case nums = [23,2,4,6,6] , k = 7 ==> without that line we won't be able to detect subarrays that start from the beginning.
    for (let i = 0; i < nums.length; i++) {
        sum += nums[i];
        let r = sum % k;
        if (!remaindersMap.has(r)) {
            remaindersMap.set(r, i);
        }
        else if (i - remaindersMap.get(r) > 1) {
            return true;
        }
    }
    return false;
};