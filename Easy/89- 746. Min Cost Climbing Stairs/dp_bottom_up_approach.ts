// solving it ascendingly won't work 
// we need to solve it descendingly aka from the top
function minCostClimbingStairs(cost: number[]): number {
    const n = cost.length
    const dp = new Array(n + 1)

    dp[n] = 0 //no cost if you are at the destination
    dp[n - 1] = cost[n - 1] //cost of standing at the last step
    dp[n - 2] = cost[n - 2] //cost of standing at the second last step

    // start iterating from the third last step
    for (let i = n - 3; i >= 0; i--) {
        //calculate min cost for every step
        dp[i] = cost[i] + Math.min(dp[i + 1], dp[i + 2])
    }

    // we used min to chose if we want to step on second step and hop to the destination
    // to avoid the first step
    // or we want to stand on the first step and avoid the second step
    return Math.min(dp[0], dp[1])
};
