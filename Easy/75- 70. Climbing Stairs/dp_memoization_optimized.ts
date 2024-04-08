//multi approaches with zero space complexity
//https://leetcode.com/problems/climbing-stairs/solutions/4211515/0ms-very-easy-beginner-friendly-code-faster-all-three-approaches/
//explains why n-3 + n-2 is better than n-1 + n-2
//https://leetcode.com/problems/climbing-stairs/solutions/3399534/one-liner-javascript-typescript-solution-with-recursion/
function climbStairs(n: number): number {
    const dp: number[] = new Array(n)
    dp[0] = 0
    dp[1] = 1
    dp[2] = 2
    dp[3] = 3
    return climbStairsHelper(n, dp);
}

function climbStairsHelper(n: number, dp: number[]): number {
    if (dp[n]) {
        return dp[n];
    }

    dp[n] = 2 * climbStairsHelper(n - 2, dp) + climbStairsHelper(n - 3, dp);
    return dp[n];
}
