function findMaxLength(nums: number[]): number {
    // If the array has 0 or 1 elements, no contiguous subarray possible
    if (nums.length <= 1) return 0;

    // Map to store the first occurrence of each sum
    const sumMap = new Map<number, number>();
    
    // Initialize with sum 0 at index -1 (before the array starts)
    sumMap.set(0, -1);
    
    let maxLength = 0;
    let currentSum = 0;

    // Treat 0 as -1 and 1 as 1
    for (let i = 0; i < nums.length; i++) {
        // Update current sum: 0 becomes -1, 1 becomes 1
        currentSum += nums[i] === 0 ? -1 : 1;

        // If we've seen this sum before, we have a subarray with equal 0s and 1s
        if (sumMap.has(currentSum)) {
            // Update max length if current subarray is longer
            maxLength = Math.max(maxLength, i - sumMap.get(currentSum)!);
        } else {
            // Store the first occurrence of this sum
            sumMap.set(currentSum, i);
        }
    }

    return maxLength;
};
