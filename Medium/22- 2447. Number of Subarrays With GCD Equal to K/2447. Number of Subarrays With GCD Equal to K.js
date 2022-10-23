/**
 * @param {number[]} nums
 * @param {number} k
 * @return {number}
 */
var subarrayGCD = function (nums, k) {
    let res = 0;
    for (let i = 0; i < nums.length; i++) {
        let currentGcd = gcd_two_numbers(nums[i], nums[i]);
        for (let j = i; j < nums.length; j++) {
            currentGcd = gcd_two_numbers(currentGcd, nums[j]);

            if (currentGcd === k)
                res++;

            else if (nums[j] % k !== 0)// the num is not dividable by k
                break;
        }
    }
    return res;
};

var gcd_two_numbers = function (x, y) {
    while (y) {
        let t = y;
        y = x % y;
        x = t;
    }
    return x;
}