class Solution
{
public:
    int tribonacci(int n)
    {
        if (n == 0)
            return 0;
        else if (n == 1 || n == 2)
            return 1;

        int x = 0, xx = 1, xxx = 1, tri;

        for (int i = 3; i <= n; i++)
        {
            tri = x + xx + xxx;
            x=xx;
            xx=xxx;
            xxx=tri;
        }
        return tri;
    }
};