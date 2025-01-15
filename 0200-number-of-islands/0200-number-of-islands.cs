public class Solution {
    public int NumIslands(char[][] grid) {
        int islands = 0;
        
        for (int row = 0; row < grid.Length; ++row) {
            for (int col = 0; col < grid[0].Length; ++col) {
                if (grid[row][col] == '1') {
                    DFS(grid, row, col);
                    ++islands;
                }
            }
        }
        
        return islands;
    }

    private void DFS(char[][] grid, int row, int col) {
        if (!isInBounds(grid, row, col) || grid[row][col] == '0')
            return;
        
        grid[row][col] = '0';

        DFS(grid, row - 1, col);
        DFS(grid, row + 1, col);
        DFS(grid, row, col - 1);
        DFS(grid, row, col + 1);
    }

    private bool isInBounds(char[][] grid, int row, int col) {
        return row >= 0 && col >= 0 && row < grid.Length && col < grid[0].Length;
    }
}