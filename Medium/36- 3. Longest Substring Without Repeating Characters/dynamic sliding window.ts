function lengthOfLongestSubstring(s: string): number {
    if (s.length <= 1)
        return s.length

    const charSet = new Set<string>()


    let maxLength = 0;
    let l = 0;

    for (let r = 0; r < s.length; r++) {
        // If the current character is already in the set, move the left pointer
        // and remove characters from the set until the duplicate is removed
        while (charSet.has(s[r])) {
            charSet.delete(s[l]);
            l++;
        }

        charSet.add(s[r]);
        maxLength = Math.max(maxLength, r - l + 1);
    }

    return maxLength
};
