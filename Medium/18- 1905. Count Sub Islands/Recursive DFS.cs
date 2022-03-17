public class Solution
{
    private readonly int[,] directions = new int[4, 2] { { -1, 0 }, { 1, 0 }, { 0, -1 }, { 0, 1 } };
    public int CountSubIslands(int[][] grid1, int[][] grid2)
    {
        // 0 water 
        // 1 land
        // grid1 and two have the same dimensions
        int res = 0;
        for (int i = 0; i < grid1.Length; i++)
        {
            for (int j = 0; j < grid1[0].Length; j++)
            {
                if (grid2[i][j] == 1 && isSubIsland(grid1, grid2, i, j))
                    res++;
            }
        }

        return res;
    }

    private bool isSubIsland(int[][] grid1, int[][] grid2, int i, int j)
    {
        if (i < 0 || i > grid1.Length - 1 || j < 0 || j > grid1[0].Length - 1 || grid2[i][j] == 0)
            return true;

        if (grid2[i][j] == 1 && grid1[i][j] == 0)
            return false;

        grid2[i][j] = 0;

        bool isSub = true;

        for (int k = 0; k < directions.GetLength(0); k++)
        {
            if (!isSubIsland(grid1, grid2, i + directions[k, 0], j + directions[k, 1]))
                isSub = false;
        }

        return isSub;
    }
}