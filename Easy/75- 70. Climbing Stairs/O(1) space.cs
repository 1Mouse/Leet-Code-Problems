public class Solution
{
    // https://www.youtube.com/watch?v=Y0lT9Fck7qI&ab_channel=NeetCode
    // https://www.youtube.com/watch?v=uHAToNgAPaM&ab_channel=KevinNaughtonJr.
    public int ClimbStairs(int n)
    {
        // top-down approach
        int first = 1;
        int second = 1;
        for (int i = 2; i <= n; i++)
        {
            int temp=second;
            second=first+second;
            first=temp;
        }
        return second;
    }
}