//multi approaches with zero space complexity
//https://leetcode.com/problems/climbing-stairs/solutions/4211515/0ms-very-easy-beginner-friendly-code-faster-all-three-approaches/
//explains why n-3 + n-2 is better than n-1 + n-2
//https://leetcode.com/problems/climbing-stairs/solutions/3399534/one-liner-javascript-typescript-solution-with-recursion/
function climbStairs(n: number): number {
    if (n <= 2) return n;
    let firstNum= 1, secondNum= 2, thirdNum= 0;
    for (let i= 3; i <= n; i++) {
        thirdNum = firstNum + secondNum;
        firstNum = secondNum;
        secondNum = thirdNum;
    }
    return thirdNum;
}
