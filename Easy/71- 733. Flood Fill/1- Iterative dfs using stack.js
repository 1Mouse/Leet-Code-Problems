/**
 * @param {number[][]} image
 * @param {number} sr
 * @param {number} sc
 * @param {number} newColor
 * @return {number[][]}
 */
var floodFill = function (image, sr, sc, newColor) {
    if (image[sr][sc] === newColor) return image;
    let rows = image.length;
    let columns = image[0].length;
    let startingColor = image[sr][sc];
    let visited = new Set();
    return dfs(image, sr, sc, rows, columns, startingColor, newColor, visited);
};

let dfs = function (
    image,
    i,
    j,
    rows,
    columns,
    startingColor,
    newColor,
    visited
) {
    visited.add([i, j]);
    let stack = [];
    stack.push([i, j]);
    image[i][j] = newColor;

    while (stack.length !== 0) {
        let current = stack.pop();

        for (let direction of directions) {
            let r = current[0] + direction[0],
                c = current[1] + direction[1];
            if (
                r < rows &&
                r >= 0 &&
                c < columns &&
                c >= 0 &&
                image[r][c] === startingColor &&
                !visited.has([r, c])
            ) {
                stack.push([r, c]);
                visited.add([r, c]);
                image[r][c] = newColor;
            }
        }
    }
    return image;
};
var directions = [
    [-1, 0],
    [1, 0],
    [0, -1],
    [0, 1],
];
