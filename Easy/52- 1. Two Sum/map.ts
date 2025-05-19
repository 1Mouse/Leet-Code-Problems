function twoSum(nums: number[], target: number): number[] {
    const subTotalMap = new Map<number, number>();

    for (let i = 0; i < nums.length; i++) {
        const current = nums[i];
        if (subTotalMap.has(target - current)) {
            return [subTotalMap.get(target - current)!, i]
        } else {
            subTotalMap.set(current, i)
        }
    }

    // won't happen as there is always a solution according to problem
    return []
};
