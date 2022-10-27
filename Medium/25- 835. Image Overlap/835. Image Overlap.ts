function largestOverlap(img1: number[][], img2: number[][]): number {
    let maxNumberofOverlaps = 0;
    for (let i = -1 * img1.length; i < img1.length; i++) {
        for (let j = -1 * img1.length; j < img1.length; j++) {
            maxNumberofOverlaps = Math.max(overlap(img1, img2, i, j), maxNumberofOverlaps);
        }
    }
    return maxNumberofOverlaps;
};

function overlap(img1: number[][], img2: number[][], rowOffset: number, columnOffset: number): number {
    let countOfOverlapedOnes = 0;
    for (let i = 0; i < img1.length; i++) {
        for (let j = 0; j < img1.length; j++) {
            if ((i + rowOffset < 0 || i + rowOffset >= img1.length) || (j + columnOffset < 0 || j + columnOffset >= img1.length))
                continue;

            if (img1[i][j] === 1 && img2[i + rowOffset][j + columnOffset] === 1)
                countOfOverlapedOnes++;
        }
    }
    return countOfOverlapedOnes;
};