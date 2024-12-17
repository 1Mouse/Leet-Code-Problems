function subarraySum(nums: number[], k: number): number {
    let countSubarrays = 0;
    let currentSum = 0;
    const prefixSumMap = new Map<number, number>();

    // Initialize with prefix sum 0 (to handle cases where currentSum equals k)
    prefixSumMap.set(0, 1); // sum 0 happened 1 time before starting for any array

    for (const num of nums) {
        // Calculate the running sum (prefix sum)
        currentSum += num;

        // Check if there is a prefix sum that satisfies the condition
        const complement = currentSum - k;

        if (prefixSumMap.has(complement)) {
            countSubarrays += prefixSumMap.get(complement)!;
        }

        // Update the prefix sum map
        prefixSumMap.set(currentSum, (prefixSumMap.get(currentSum) || 0) + 1);
    }

    return countSubarrays;
}
