/**
 * @param {string} s
 * @param {string} p
 * @return {number[]}
 */
var findAnagrams = function (s, p) {
    if (p.length > s.length)
        return [];

    let freq = new Map();
    let res = [];
    for (let c of p) {
        freq.set(c, (freq.has(c) ? 1 + freq.get(c) : 1));
    }


    for (let i = 0; i <= s.length - p.length; i++) {
        let copy = new Map();
        let isAnagram = true;
        for (let j = i; j < i + p.length; j++) {
            if (!freq.has(s[j])) {
                i = j;
                isAnagram = false;
                break;
            }
            else {
                (copy.set(s[j], (copy.has(s[j]) ? 1 + copy.get(s[j]) : 1)));
            }

            if (copy.get(s[j]) > freq.get(s[j])) {
                isAnagram = false;
                break;
            }
        }
        if (isAnagram === true) res.push(i);
    }

    return res;

};

