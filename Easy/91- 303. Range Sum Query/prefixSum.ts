class NumArray {
    prefixSum: number[] = []

    constructor(nums: number[]) {
        this.prefixSum[0] = nums[0]

        for (let i = 1; i < nums.length; i++)
            this.prefixSum[i] = this.prefixSum[i - 1] + nums[i]

    }

    sumRange(left: number, right: number): number {
        // If left is 0, simply return prefix sum at right
        if (left === 0)
            return this.prefixSum[right]

        // Otherwise, subtract prefix sum up to left-1 from prefix sum at right
        return this.prefixSum[right] - this.prefixSum[left - 1]
    }
}

/**
 * Your NumArray object will be instantiated and called as such:
 * var obj = new NumArray(nums)
 * var param_1 = obj.sumRange(left,right)
 */


