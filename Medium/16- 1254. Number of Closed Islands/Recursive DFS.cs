public class Solution
{
    private HashSet<KeyValuePair<int, int>> visited = new HashSet<KeyValuePair<int, int>>();
    public int ClosedIsland(int[][] grid)
    {
        int rows = grid.Length;
        int columns = grid[0].Length;
        int numberOfClosedIslands = 0;
        // we iterate at these limits to excluse the perimeter
        for (int i = 1; i < rows - 1; i++)
        {
            for (int j = 1; j < columns - 1; j++)
            {
                if (grid[i][j] == 0 && !visited.Contains(new KeyValuePair<int, int>(i, j)))
                {
                    if (isClosedIsland(i, j, grid, rows, columns))
                        numberOfClosedIslands++;
                }
            }
        }
        return numberOfClosedIslands;
    }

    private bool isClosedIsland(int i, int j, int[][] grid, int rows, int columns)
    {
        // Base case is if we found water '1' or if we found a land that is already visited 
        if (grid[i][j] == 1 || visited.Contains(new KeyValuePair<int, int>(i, j))) return true;

        if (isOnPertimeter(i, j, rows, columns)) return false;

        visited.Add(new KeyValuePair<int, int>(i, j));

        bool DfsLeft = isClosedIsland(i - 1, j, grid, rows, columns);
        bool DfsRight = isClosedIsland(i + 1, j, grid, rows, columns);
        bool DfsUp = isClosedIsland(i, j - 1, grid, rows, columns);
        bool DfsDown = isClosedIsland(i, j + 1, grid, rows, columns);

        return DfsLeft && DfsRight && DfsUp && DfsDown;
    }

    private bool isOnPertimeter(int i, int j, int rows, int columns)
    {
        return i == 0 || j == 0 || i == rows - 1 || j == columns - 1;
    }
}