function maxLength(arr: string[]): number {
    let vaildConcatenation: string[] = [''];
    let max = 0;
    for (let i = 0; i < arr.length; i++) {
        if (!isUnique(arr[i])) continue;

        let currentvaildConcatenation: string[] = [];
        for (let candidate of vaildConcatenation) {
            let temp = candidate + arr[i];
            if (isUnique(temp)) currentvaildConcatenation.push(temp);
        }
        vaildConcatenation = [...vaildConcatenation, ...currentvaildConcatenation];
    }
    
    for (let str of vaildConcatenation) max = Math.max(max, str.length);
    return max;
};

function isUnique(str: string): boolean {
    let freq = Array.from({ length: 26 }, () => false);

    for (let c = 0; c < str.length; c++) {
        let asciiValue = str.charCodeAt(c) - 97; // 'a' = 97
        if (freq[asciiValue])
            return false;
        else
            freq[asciiValue] = true;
    }
    return true;
}