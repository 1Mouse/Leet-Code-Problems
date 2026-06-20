func searchMatrix(matrix [][]int, target int) bool {
	rows, cols := len(matrix), len(matrix[0])

	l, r := 0, rows*cols-1
	var m int

	for l <= r {
		m = l + (r-l)/2

		row, col := m/cols, m%cols

		val := matrix[row][col]

		if val == target {
			return true
		} else if val > target {
			r = m - 1
		} else {
			l = m + 1
		}
	}

	return false
}
