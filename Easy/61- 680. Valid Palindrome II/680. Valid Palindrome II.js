/**
 * @param {string} s
 * @return {boolean}
 */
var validPalindrome = function (s) {
    let pointer1 = 0,
        pointer2 = s.length - 1;

    while (pointer1 < pointer2) {
        if (s[pointer1] !== s[pointer2]) {
            return isPalindrome(s.slice(0, pointer2) + s.slice(pointer2 + 1))
                ? true
                : isPalindrome(s.slice(0, pointer1) + s.slice(pointer1 + 1));
        }
        pointer1++;
        pointer2--;
    }
    return isPalindrome(s);
};

function isPalindrome(s) {
    let pointer1 = 0;
    let pointer2 = s.length - 1;

    while (pointer1 < pointer2) {
        if (s[pointer1] !== s[pointer2]) {
            return false;
        }
        pointer1++;
        pointer2--;
    }
    return true;
}
