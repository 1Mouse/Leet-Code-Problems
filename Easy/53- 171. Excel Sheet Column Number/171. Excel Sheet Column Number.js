/**
 * @param {string} columnTitle
 * @return {number}
 */
var titleToNumber = function (columnTitle) {
    const charCodeBase = "@".charCodeAt(0);
    let ans = 0;
    for (var i = 0; i < columnTitle.length; i++) {
        ans *= 26;
        ans += columnTitle.charCodeAt(i) - charCodeBase;
    }
    return ans;
};
