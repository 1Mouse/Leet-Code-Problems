public class Solution
{
    public bool IsPowerOfFour(int n)
    {
        return n > 0 && (n == 1 || (n % 4 == 0 && IsPowerOfFour(n / 4)));
    }
}