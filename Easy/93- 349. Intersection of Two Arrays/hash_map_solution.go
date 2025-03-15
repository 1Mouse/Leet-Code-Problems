func intersection(nums1 []int, nums2 []int) []int {
  set := make(map[int]bool)
	result := []int{}

	// Store unique elements of nums1 in a map
	for _, num := range nums1 {
		set[num] = true
	}

	// Check if elements of nums2 exist in the map
	seen := make(map[int]bool) // To avoid duplicates in the result
	for _, num := range nums2 {
		if set[num] && !seen[num] {
			result = append(result, num)
			seen[num] = true
		}
	}

	return result
}
