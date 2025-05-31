

function isPalindrome(s: string): boolean {
    let l: number = 0;
    let r: number = s.length - 1; 
    
    while (l < r) {
        while (l < r && !isAlphanumeric(s[l])) l++;
        while (l < r && !isAlphanumeric(s[r])) r--;
        
        if (s[l].toLowerCase() !== s[r].toLowerCase()) return false;
        l++;
        r--;
    }
    return true;
}

function isAlphanumeric(char: string): boolean {
    return new RegExp(/[a-zA-Z0-9]/).test(char);
}
