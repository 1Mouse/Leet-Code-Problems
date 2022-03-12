/**
 * @param {number[][]} grid
 * @return {number}
 */
var maxAreaOfIsland = function (grid) {
    let rows = grid.length;
    let columns = grid[0].length;

    // better to use a set but js give me error:
    // RangeError: Value undefined out of range for undefined options property undefined at Set.add (<anonymous>)
    // initialize the 2D array to a value of false for all vertices
    // as by default the array contains undefined values and we can't check an if condition for undefined value
    let visited = new Array(rows)
        .fill(false)
        .map(() => new Array(columns).fill(false));

    let maxArea = 0;

    for (let i = 0; i < rows; i++) {
        for (let j = 0; j < columns; j++) {
            if (grid[i][j] === 1 && visited[i][j] === false) {
                let currentMax = 0;
                currentMax += dfs(grid, i, j, rows, columns, visited, currentMax);
                maxArea = Math.max(currentMax, maxArea);
            }
        }
    }

    return maxArea;
};

let dfs = function (grid, i, j, rows, columns, visited, currentMax) {
    let stack = [];
    stack.push([i, j]);
    visited[i][j] = true;

    while (stack.length !== 0) {
        let current = stack.pop();
        currentMax++;

        for (let direction of directions) {
            let r = current[0] + direction[0],
                c = current[1] + direction[1];
            if (
                r < rows &&
                r >= 0 &&
                c < columns &&
                c >= 0 &&
                grid[r][c] === 1 &&
                visited[r][c] === false
            ) {
                stack.push([r, c]);
                visited[r][c] = true;
            }
        }
    }

    return currentMax;
};

var directions = [
    [-1, 0],
    [1, 0],
    [0, 1],
    [0, -1],
];
