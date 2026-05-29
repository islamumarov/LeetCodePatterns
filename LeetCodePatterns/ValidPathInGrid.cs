namespace LeetCodePatterns;

public class ValidPathInGrid
{
    /*
     * You are given an m x n grid. Each cell of grid represents a street. The street of grid[i][j] can be:

       1 which means a street connecting the left cell and the right cell.
       2 which means a street connecting the upper cell and the lower cell.
       3 which means a street connecting the left cell and the lower cell.
       4 which means a street connecting the right cell and the lower cell.
       5 which means a street connecting the left cell and the upper cell.
       6 which means a street connecting the right cell and the upper cell.

     *
     *
     * You will initially start at the street of the upper-left cell (0, 0). A valid path in the grid is a path that starts from the upper left cell (0, 0) and ends at the bottom-right cell (m - 1, n - 1). The path should only follow the streets.
     * Notice that you are not allowed to change any street.
     * Return true if there is a valid path in the grid or false otherwise.
     */
    public bool HasValidPath(int[][] grid)
    {
        var m = grid.Length;
        var n = grid[0].Length;

        var directions = new (int dx, int dy)[] { (0, 1), (0, -1), (1, 0), (-1, 0) };

        var visited = new bool[m, n];

        return HasValidPathRecursive(grid, 0, 0, directions, visited);
    }

    private bool HasValidPathRecursive(int[][] grid, int x, int y, (int dx, int dy)[] directions, bool[,] visited)
    {
        var m = grid.Length;
        var n = grid[0].Length;

        if (x < 0 || x >= m || y < 0 || y >= n || visited[x, y]) return false;

        if (x == m - 1 && y == n - 1) return true;

        visited[x, y] = true;

        foreach (var (dx, dy) in GetDirections(grid[x][y]))
        {
            var nextX = x + dx;
            var nextY = y + dy;

            if (nextX < 0 || nextX >= m || nextY < 0 || nextY >= n || visited[nextX, nextY]) continue;

            if (!CanConnectBack(grid[nextX][nextY], -dx, -dy)) continue;

            if (HasValidPathRecursive(grid, nextX, nextY, directions, visited)) return true;
        }

        return false;
    }

    private static (int dx, int dy)[] GetDirections(int streetType)
    {
        return streetType switch
        {
            1 => [(0, -1), (0, 1)],
            2 => [(-1, 0), (1, 0)],
            3 => [(0, -1), (1, 0)],
            4 => [(0, 1), (1, 0)],
            5 => [(0, -1), (-1, 0)],
            6 => [(0, 1), (-1, 0)],
            _ => []
        };
    }

    private static bool CanConnectBack(int streetType, int dx, int dy)
    {
        foreach (var direction in GetDirections(streetType))
            if (direction.dx == dx && direction.dy == dy)
                return true;

        return false;
    }
}