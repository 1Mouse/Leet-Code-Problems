public class Solution{
    private HashSet<KeyValuePair<int, int>> visited = new HashSet<KeyValuePair<int, int>>();
    private int[,] directions = new int[,] { { 1, 0 }, { -1, 0 }, { 0, 1 }, { 0, -1 } };
    public int NumEnclaves(int[][] grid)
    {
        // 0 --> sea
        // 1 --> land
        int numberOfEnclaves = 0;
        int rows = grid.Length;
        int columns = grid[0].Length;

        // we iterate at these limits to excluse the perimeter
        for (int i = 1; i < rows - 1; i++)
        {
            for (int j = 1; j < columns - 1; j++)
            {
                if (grid[i][j] == 1 && !visited.Contains(new KeyValuePair<int, int>(i, j)))
                {
                    numberOfEnclaves += isAnEnclave(i, j, grid, rows, columns);
                }
            }
        }
        return numberOfEnclaves;
    }
    //DFS
    private int isAnEnclave(int i, int j, int[][] grid, int rows, int columns)
    {
        int counter = 0;
        var stack = new Stack<KeyValuePair<int, int>>();
        visited.Add(new KeyValuePair<int, int>(i, j));
        stack.Push(new KeyValuePair<int, int>(i, j));

        while (stack.Count != 0)
        {
            var current = stack.Pop();
            counter++;
            for (int k = 0; k < directions.GetLength(0); k++)
            {
                int r = current.Key + directions[k, 0], c = current.Value + directions[k, 1];
                if (r < rows - 1 && r > 0 && c < columns - 1 && c > 0 && grid[r][c] == 1 && !visited.Contains(new KeyValuePair<int, int>(r, c)))
                {
                    visited.Add(new KeyValuePair<int, int>(r, c));
                    stack.Push(new KeyValuePair<int, int>(r, c));
                }
                if (grid[r][c] == 1 && isOnPertimeter(r, c, rows, columns))
                {
                    return 0; // you don't want to return and exit the function until you have explored all the neighboored 1s so instead use a flag like in the next solution
                }

            }
        }

        return counter;
    }
    private bool isOnPertimeter(int i, int j, int rows, int columns)
    {
        return i == 0 || j == 0 || i == rows - 1 || j == columns - 1;
    }
}