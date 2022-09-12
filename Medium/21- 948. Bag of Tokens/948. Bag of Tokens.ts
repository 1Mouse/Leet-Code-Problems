function bagOfTokensScore(tokens: number[], power: number): number {
    // up   ==> decrease power, +1 score
    // down ==> increase power, -1 score
    tokens.sort((a, b) => a - b);
    let i = 0, j = tokens.length - 1;
    let score = 0;
    while (i <= j) {
        if (tokens[i] <= power) {
            score++;
            power -= tokens[i++];
        }
        else if (score >= 1 && i < j) {
            score--;
            power += tokens[j--];
        }
        else break; // to pass the test of [100] and power 50
    }
    return score;
};