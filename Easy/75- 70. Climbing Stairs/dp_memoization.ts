function climbStairs(n: number): number {
    const dp: number[] = new Array(n)
    dp[0] = 0
    dp[1] = 1
    dp[2] = 2
    return climbStairsHelper(n, dp);
}

function climbStairsHelper(n: number, dp: number[]): number {
    if (dp[n]) {
        return dp[n];
    }

    dp[n] = climbStairsHelper(n - 1, dp) + climbStairsHelper(n - 2, dp);
    return dp[n];
}
