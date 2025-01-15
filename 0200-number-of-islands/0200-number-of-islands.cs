public class Solution {
    (int Row, int Col)[] directions = new[] {(-1, 0), (1, 0), (0, -1), (0, 1)};

    public int NumIslands(char[][] grid) {

        int islands = 0;

        for (int i = 0; i < grid.Length; ++i) {
            for (int j = 0; j < grid[0].Length; ++j) {
                if (grid[i][j] == '1') {
                    ++islands;
                    VisitIsland(grid, i, j);
                }
            }
        }

        return islands;
    }

    private void VisitIsland(char[][] grid, int r, int c) {
        var q = new Queue<(int Row, int Col)>();
        q.Enqueue((r, c));
        while (q.Count > 0) {
            var current = q.Dequeue();
            foreach (var dir in directions) {
                int row = current.Row + dir.Row;
                int col = current.Col + dir.Col;

                if (IsInBounds(grid, row, col) && grid[row][col] == '1') {
                    grid[row][col] = 'v';
                    q.Enqueue((row, col));
                }
            }
        }
    }

    private bool IsInBounds(char[][] grid, int row, int col) {
        return row >= 0 && row < grid.Length && col >= 0 && col < grid[0].Length;
    }
}