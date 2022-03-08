public class Solution
{
    public int NumIslands(char[][] grid)
    {
        int rows = grid.Length;
        int columns = grid[0].Length;

        var visited = new HashSet<KeyValuePair<int, int>>();
        int numberOfIslands = 0;

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                if (grid[i][j] == '1' && !visited.Contains(new KeyValuePair<int, int>(i, j)))
                {
                    bfs(i, j, visited, rows, columns, grid);
                    numberOfIslands++;
                }

            }
        }

        return numberOfIslands;
    }
    private void bfs(int i, int j, HashSet<KeyValuePair<int, int>> visited, int rows, int columns, char[][] grid)
    {
        var q = new Queue<KeyValuePair<int, int>>();
        visited.Add(new KeyValuePair<int, int>(i, j));
        q.Enqueue(new KeyValuePair<int, int>(i, j));

        while (q.Count != 0)
        {
            int currentI = q.Peek().Key;
            int currentJ = q.Dequeue().Value;

            KeyValuePair<short, short>[] directions = {
                new KeyValuePair<short, short>(1,0),//right
                new KeyValuePair<short, short>(-1,0),//left
                new KeyValuePair<short, short>(0,-1),//up
                new KeyValuePair<short, short>(0,1),//down
                };

            foreach (var direction in directions)
            {
                int r = currentI + direction.Key, c = currentJ + direction.Value;
                if (r < rows && r >= 0 && c < columns && c >= 0 && grid[r][c] == '1' && !visited.Contains(new KeyValuePair<int, int>(r, c)))
                {
                    q.Enqueue(new KeyValuePair<int, int>(r, c));
                    visited.Add(new KeyValuePair<int, int>(r, c));
                }
            }
        }
    }
}