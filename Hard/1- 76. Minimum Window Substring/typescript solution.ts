function minWindow(s: string, t: string): string {
    let mapT = new Map<string, number>();
    for (let i = 0; i < t.length; i++) {
        mapT.set(t[i], (mapT.has(t[i]) ? 1 + mapT.get(t[i]) : 1));
    }

    let matched = 0, start = 0, minLength = s.length + 1, subStr = 0;
    for (let end = 0; end < s.length; end++) {
        if (mapT.has(s[end])) {
            mapT.set(s[end], mapT.get(s[end]) - 1);
            matched = (mapT.get(s[end]) === 0) ? ++matched : matched;
        }

        while (matched === mapT.size) {
            let currentLengthOfSubstring = end - start + 1;
            if (currentLengthOfSubstring < minLength) {
                minLength = currentLengthOfSubstring;
                subStr = start;
            }

            let deleted = s[start++];
            if (mapT.has(deleted)) {
                matched = (mapT.get(deleted) === 0) ? --matched : matched;
                mapT.set(deleted, mapT.get(deleted) + 1);
            }
        }
    }
    return minLength > s.length ? "" : s.substring(subStr, subStr + minLength);
};