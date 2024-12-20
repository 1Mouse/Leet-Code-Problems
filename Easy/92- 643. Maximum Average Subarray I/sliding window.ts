function findMaxAverage(nums: number[], k: number): number {
    let sum = 0
    let maxSum = 0

  // initialize the sum and maxSum with the first k elements
    for (let i = 0; i < k; i++) {
        sum += nums[i];
    }
    maxSum = sum;

    // slide the window adding one element to the end and removing one element from the start
    for (let i = k; i < nums.length; i++) {
        sum = sum + nums[i] - nums[i - k];

        maxSum = Math.max(sum, maxSum)
    }

    return maxSum / k
};
