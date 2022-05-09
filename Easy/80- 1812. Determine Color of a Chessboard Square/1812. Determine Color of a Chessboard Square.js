/**
 * @param {string} coordinates
 * @return {boolean}
 */
var squareIsWhite = function (coordinates) {
    if (
        coordinates[0] === "b" ||
        coordinates[0] === "d" ||
        coordinates[0] === "f" ||
        coordinates[0] === "h"
    )
        return coordinates[1] % 2 === 1;
    else return coordinates[1] % 2 === 0;
};
