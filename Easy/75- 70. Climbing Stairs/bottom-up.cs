// bottom up vs top down
// https://medium.com/cracking-the-coding-interview-in-ruby-python-and/bottom-up-and-top-down-recursion-explained-with-examples-in-ruby-javascript-and-python-mastering-9fa051ee53ff
public class Solution
{
    public int ClimbStairs(int n)
    {
        int[] dp = new int[n + 1];
        dp[n] = 1;
        dp[n-1] = 1;
        for (int i = n-2; i >=0; i--)
        {
            dp[i] = dp[i + 1] + dp[i + 2];
        }
        return dp[0];
    }
}
