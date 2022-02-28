/**
 * @param {number[]} nums
 * @return {string[]}
 */
var summaryRanges = function (nums) {
    let result = [];
    for (let i = 0; i < nums.length; i++) {
        let start = nums[i];
        while (i < nums.length - 1 && nums[i + 1] - nums[i] == 1) {
            i++;
        }
        if (start != nums[i]) result.push(`${start}->${nums[i]}`);
        else result.push(start.toString());
    }
    return result;
};
