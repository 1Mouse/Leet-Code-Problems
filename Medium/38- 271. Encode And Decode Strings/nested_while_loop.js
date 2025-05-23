//https://neetcode.io/problems/string-encode-and-decode
//https://www.lintcode.com/problem/659/discuss
class Solution {

  /**
   * @param {string[]} strs
   * @returns {string}
   */
  encode(strs) {
    let res = '';

    for (let s of strs) res += `${s.length}#${s}`;

    return res;
  }

  /**
   * @param {string} str
   * @returns {string[]}
   */
  decode(str) {
    let res = []
    let i = 0;

    while (i < str.length) {
      let j = i;
      // find how many indexes represent the (number) before the #
      while (str[j] !== '#') {
        j++;
      }
      //3#now10#1234567894
      let length = +str.substring(i, j)
      i = j + 1; 
      j = i + length; 
      res.push(str.substring(i, j));
      i = j;
    }

    return res;
  }
}
