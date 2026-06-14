func longestConsecutive(nums []int) int {
	// [100, 4, 200, 1, 3, 2]
	// 1,2,3,4,100,200

	set := make(map[int]struct{}, len(nums))
	// loop first to occupy the map
	for _, val := range nums {
		set[val] = struct{}{}
	}

	maxLen := 0

	for x := range set {
		if _, exists := set[x-1]; !exists {
			currLen := 1
			curr := x

			for {
				if _, exists := set[curr+1]; exists {
					curr++
					currLen++
				} else {
					break
				}

			}

			if currLen > maxLen {
				maxLen = currLen
			}
		}

	}

	return maxLen
}
