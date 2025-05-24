function productExceptSelf(nums: number[]): number[] {
    const result = new Array(nums.length).fill(1);

    // Step 1: Calculate prefix products
    let prefix = 1;
    for (let i = 0; i < nums.length; i++) {
        result[i] = prefix;
        prefix *= nums[i];
    }

    // Step 2: Calculate suffix products and multiply with the result
    let suffix = 1;
    for (let i = nums.length - 1; i >= 0; i--) {
        result[i] *= suffix;
        suffix *= nums[i];
    }

    return result;
}
