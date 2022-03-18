public class Solution
{
    private bool flag;
    public int CountSubIslands(int[][] grid1, int[][] grid2)
    {
        int n = grid1.Length, m = grid1[0].Length;
        bool[,] visited = new bool[n, m];
        int res = 0;

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                if (grid2[i][j] == 1 && !visited[i, j])
                {
                    flag = true;
                    dfs(grid1, grid2, i, j, visited);
                    if (flag)
                        res++;
                }
            }
        }

        return res;
    }

    private void dfs(int[][] grid1, int[][] grid2, int i, int j, bool[,] visited)
    {
        // stop when you get out of range or when you get water or a visited land
        if (i < 0 || i >= grid1.Length || j < 0 || j >= grid1[0].Length || visited[i, j] || grid2[i][j] == 0)
        {
            return;
        }
        // if there is land in grid2 and water in grid1 return false
        if (grid1[i][j] == 0 && grid2[i][j] == 1)
        {
            flag = false;
            return;
        }

        visited[i, j] = true;
        dfs(grid1, grid2, i + 1, j, visited);
        dfs(grid1, grid2, i, j + 1, visited);
        dfs(grid1, grid2, i - 1, j, visited);
        dfs(grid1, grid2, i, j - 1, visited);
    }
}