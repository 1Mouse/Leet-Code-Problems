function findDuplicate(nums: number[]): number {
    let slow = 0;
    let fast = 0;

    // Phase 1: Find intersection point of Tortoise and Hare
    do {
        slow = nums[slow];
        fast = nums[nums[fast]];
    } while (slow !== fast);

    // Phase 2: Find entrance to the cycle
    let slow2 = 0;
    while (slow !== slow2) {
        slow = nums[slow];
        slow2 = nums[slow2];
    }

    return slow;
};
