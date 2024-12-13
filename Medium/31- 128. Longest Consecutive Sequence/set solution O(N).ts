function longestConsecutive(nums: number[]): number {

    if (nums.length === 0 || nums.length === 1) {
        return nums.length
    }

    const numSet = new Set(nums)

    let longestStreak = 0;


    for (let entry of numSet) {
        console.log(entry)

        //only start counting if this is the start of the sequence
        if (!numSet.has(entry - 1)) { //O(1) retrieval
            let currentNum = entry;
            let currentStreak = 1;

            while (numSet.has(currentNum + 1)) {
                currentNum++
                currentStreak++
            }

            longestStreak = Math.max(currentStreak, longestStreak)
        }

    }

    return longestStreak;
}
