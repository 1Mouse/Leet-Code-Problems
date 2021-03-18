/*
 * @lc app=leetcode id=463 lang=java
 *
 * [463] Island Perimeter
 */

// @lc code=start
class Solution {
    public int islandPerimeter(int[][] grid) {
        // row = how many rows in the grid
        // col = how many columns in the grid
        int row = grid.length;
        int col = grid[0].length;

        // if (grid == null || grid.length == 0)
        // return 0;

        int count = 0;
        for (int i = 0; i < row; i++) {
            for (int j = 0; j < col; j++) {
                // if 0 it's water so continue
                if (grid[i][j] == 0)
                    continue;

                if (grid[i][j] == 1) {
                    // suppose it has water from all edges
                    count += 4;

                    // check top
                    if (i > 0 && grid[i - 1][j] == 1) {
                        count--;
                    }

                    // check bottom
                    if (i < row - 1 && grid[i + 1][j] == 1) {
                        count--;
                    }

                    // check left
                    if (j > 0 && grid[i][j - 1] == 1) {
                        count--;
                    }

                    // check right
                    if (j < col - 1 && grid[i][j + 1] == 1) {
                        count--;
                    }
                }
            }
        }
        return count;
    }
}
// @lc code=end



/*Accepted 5833/5833

cases passed (6 ms)
Your runtime beats 60.67 % of java submissions
Your memory usage beats 29.63 % of java submissions (40.6 MB)*/