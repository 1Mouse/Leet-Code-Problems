/**
 * @param {string} s
 * @return {number}
 */
var romanToInt = function (s) { 
    let result=0;
    for (let i=0; i<s.length-1; i++) {
        result+=((romanNumerals(s[i])<romanNumerals(s[i+1]))?-1:1)*romanNumerals(s[i]);
    }
    return result+romanNumerals(s[s.length-1]);
};
/**
 * @param {string} c
 * @return {number}
 */
function romanNumerals(c) {
    switch (c) {
        case "I":
            return 1;
        case "V":
            return 5;
        case "X":
            return 10;
        case "L":
            return 50;
        case "C":
            return 100;
        case "D":
            return 500;
        case "M":
            return 1000;
    }
    return 0;
};
