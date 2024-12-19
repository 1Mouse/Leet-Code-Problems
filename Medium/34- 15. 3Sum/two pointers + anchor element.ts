function threeSum(nums: number[]): number[][] {
    nums.sort((a, b) => a - b);

    let triplets: Array<Array<number>> = [];

    // nums.length - 2 ensures the algorithm stops 
    // when there aren't enough elements remaining to form a triplet.
    for (let i = 0; i < nums.length - 2; i++) {
        // Remove any duplicates from anchor position before setting up pointers.
        while (nums[i] === nums[i - 1]) i++;

        let l = i + 1;
        let r = nums.length - 1;

        while (l < r) {
            const sum = nums[i] + nums[l] + nums[r];

            if (sum === 0) {
                triplets.push([nums[i], nums[l], nums[r]])

                // Remove any duplicates after finding the target sum.
                while (nums[l] === nums[l + 1]) l++;

                // Traverse one past current Non duplicate value.
                l++;
            } else if (sum < 0)
                l++;
            else
                r--;
        }

    }

    return triplets;
};
