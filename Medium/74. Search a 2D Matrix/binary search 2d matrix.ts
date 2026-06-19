function searchMatrix(matrix: number[][], target: number): boolean {
    const rows = matrix.length;
    const cols = matrix[0].length;

    let l = 0;
    let r = rows * cols - 1;

    while (l <= r) {
        const mid = l + Math.floor((r - l) / 2);

        const row = Math.floor(mid / cols);
        const col = mid % cols;

        const val = matrix[row][col];

        if (val === target) {
            return true;
        } else if (val > target) {
            r = mid - 1;
        } else {
            l = mid + 1;
        }
    }

    return false;
}
