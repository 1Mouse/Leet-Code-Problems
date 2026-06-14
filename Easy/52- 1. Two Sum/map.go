func twoSum(nums []int, target int) []int {
	occurences := make(map[int]int)
	for idx, curr := range nums {
		if prevIdx, exists := occurences[target-curr]; exists {
			return []int{prevIdx, idx}
		}

		occurences[curr] = idx
	}

	return []int{-1}
}
