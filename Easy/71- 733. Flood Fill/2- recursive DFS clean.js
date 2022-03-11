/**
 * @param {number[][]} image
 * @param {number} sr
 * @param {number} sc
 * @param {number} newColor
 * @return {number[][]}
 */
var floodFill = function (image, sr, sc, newColor) {
    if (image[sr][sc] === newColor) return image;

    dfs(image, sr, sc, image[sr][sc], newColor);

    return image;
};

let dfs = function (image, i, j, startingColor, newColor) {
    if (
        i >= image.length ||
        i < 0 ||
        j >= image[0].length ||
        j < 0 ||
        image[i][j] !== startingColor
    )
        return;

    image[i][j] = newColor;
    dfs(image, i + 1, j, startingColor, newColor); //right
    dfs(image, i - 1, j, startingColor, newColor); //left
    dfs(image, i, j - 1, startingColor, newColor); //up
    dfs(image, i, j + 1, startingColor, newColor); //down
};
