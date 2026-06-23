 func findDuplicate(nums []int) int {
    slow, fast := nums[0], nums[nums[0]]

    // Phase 1: find intersection point inside cycle
    for slow != fast {
        slow = nums[slow]
        fast = nums[nums[fast]]
    }

    // Phase 2: find cycle entry (the duplicate)
    slow = 0
    for slow != fast {
        slow = nums[slow]
        fast = nums[fast]
    }

    return slow
}
