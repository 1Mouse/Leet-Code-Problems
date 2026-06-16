func lengthOfLongestSubstring(s string) int {
	lastSeen := make(map[byte]int)
	maxLength, l := 0, 0

	for r := range s {
		if idx, exists := lastSeen[s[r]]; exists && idx >= l {
			l = idx + 1
		}

		lastSeen[s[r]] = r

		if r-l+1 > maxLength {
			maxLength = r - l + 1
		}
	}

	return maxLength
}
