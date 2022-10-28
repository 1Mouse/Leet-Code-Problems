function groupAnagrams(strs: string[]): string[][] {
    let map = new Map<string, string[]>();
    for (let s of strs) {
        let charFreq = Array.from({ length: 26 }, () => 0);
        for (let i = 0; i < s.length; i++)charFreq[s.charCodeAt(i) - 97]++;
        let keyStr = charFreq.toString();
        if (!map.has(keyStr)) map.set(keyStr, []);
        map.get(keyStr).push(s);
    }
    return Array.from(map.values());
};
