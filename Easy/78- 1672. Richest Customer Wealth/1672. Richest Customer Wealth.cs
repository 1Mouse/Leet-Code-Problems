public class Solution
{
    public int MaximumWealth(int[][] accounts)
    {
        int max = 0;

        for (int i = 0; i < accounts.Length; i++)
        {
            int currentMax = 0;

            for (int j = 0; j < accounts[0].Length; j++)
            {
                currentMax += accounts[i][j];
            }

            max = (currentMax > max) ? currentMax : max;
        }

        return max;
    }
}