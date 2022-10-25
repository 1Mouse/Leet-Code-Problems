// https://leetcode.com/problems/check-if-two-string-arrays-are-equivalent/solutions/967572/java-4-pointers-and-iterator-solution-doing-it-in-o-1-space-is-the-trick/

function arrayStringsAreEqual(word1: string[], word2: string[]): boolean {
    let innerPointer1 = 0, innerPointer2 = 0, outerPointer1 = 0, outerPointer2 = 0;
    
    while (outerPointer1 < word1.length && outerPointer2 < word2.length) {
        if (word1[outerPointer1].charAt(innerPointer1) !== word2[outerPointer2].charAt(innerPointer2))
            return false;

        if (innerPointer1 < word1[outerPointer1].length - 1)
            innerPointer1++;
        else {
            innerPointer1 = 0;
            outerPointer1++;
        }

        if (innerPointer2 < word2[outerPointer2].length - 1)
            innerPointer2++;
        else {
            innerPointer2 = 0;
            outerPointer2++;
        }
    }
    return (outerPointer2 === word2.length && outerPointer1 === word1.length);
};
