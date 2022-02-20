/**
 * @param {string} ransomNote
 * @param {string} magazine
 * @return {boolean}
 */
var canConstruct = function (ransomNote, magazine) {
    if (ransomNote.length > magazine.length) return false;

    let map = new Map();
    for (let i = 0; i < ransomNote.length; i++) {
        if (map.has(ransomNote[i])) map[ransomNote[i]]++;
        else map.set(ransomNote[i], 1);
    }
    for (let i = 0; i < magazine.length; i++) {
        if (map.has(magazine[i])) map[magazine[i]]--;
        else map.set(magazine[i], -1);
    }
    for (const c of map.values()) {
        if (c > 0) return false;
    }
    return true;
};

let ransomNote = "aa",
    magazine = "aab";
console.log(canConstruct(ransomNote, magazine));
