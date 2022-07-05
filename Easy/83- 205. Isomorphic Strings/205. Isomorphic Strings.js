/**
 * @param {string} s
 * @param {string} t
 * @return {boolean}
 */
const isIsomorphic = (s, t) => {
    let mapST = new Map(), mapTS = new Map();
    for (let i = 0; i < s.length; i++) {
        let sChar = s[i], tChar = t[i];
        if ((mapST.has(sChar) && mapST.get(sChar) !== tChar) || (mapTS.has(tChar) && mapTS.get(tChar) !== sChar))
            return false;

        mapST.set(sChar, tChar);
        mapTS.set(tChar, sChar);
    }
    return true
};