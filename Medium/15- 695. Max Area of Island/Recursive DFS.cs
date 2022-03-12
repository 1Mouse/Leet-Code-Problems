/*
Complexity Analysis

Time Complexity: O(R*C)O(R∗C), where RR is the number of rows in the given grid, and CC is the number of columns. We visit every square once.

Space complexity: O(R*C)O(R∗C), the space used by seen to keep track of visited squares, and the space used by the call stack during our recursion.
*/
public class Solution {
        private int maxArea = 0, maxNow = 0;
        private HashSet<KeyValuePair<int, int>> visited = new HashSet<KeyValuePair<int, int>>();
        public int MaxAreaOfIsland(int[][] grid)
        {
            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[0].Length; j++)
                {
                    if (grid[i][j] == 1 && !visited.Contains(new KeyValuePair<int, int>(i, j)))
                    {
                        maxNow = 0;
                        dfs(i, j, grid);
                    }
                }
            }
            return maxArea;
        }

        private void dfs(int i, int j, int[][] grid)
        {
            if (i < 0 || j < 0 ||
                i >= grid.Length || j >= grid[0].Length ||
                grid[i][j]==0||
                visited.Contains(new KeyValuePair<int, int>(i, j))) return;

            this.visited.Add(new KeyValuePair<int, int>(i, j));
            maxNow++;

            dfs(i - 1, j, grid);
            dfs(i + 1, j, grid);
            dfs(i, j + 1, grid);
            dfs(i, j - 1, grid);

            maxArea = Math.Max(maxArea, maxNow);
        }
}