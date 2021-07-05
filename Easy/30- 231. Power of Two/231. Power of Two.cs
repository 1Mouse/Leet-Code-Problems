//https://leetcode.com/problems/power-of-two/discuss/63966/4-different-ways-to-solve-Iterative-Recursive-Bit-operation-Math

public class Solution
{
    public bool IsPowerOfTwo(int n)
    {
        //direct and tricky solution
        /*if(n<=0)
            return false;
        else
            return ((n&(n-1))==0);*/

        //recursive solution
        return n > 0 && (n == 1 || (n % 2 == 0 && IsPowerOfTwo(n / 2)));
    }
}