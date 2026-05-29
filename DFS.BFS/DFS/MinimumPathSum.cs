using System.Runtime.CompilerServices;

namespace DFS;

public class MinimumPathSum
{
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int MinPathSum(int[][] grid)
    {
        var n = grid.Length;
        var m = grid[0].Length;

        for (var i = n - 1; i >= 0; i--)
        for (var j = m - 1; j >= 0; j--)
        {
            var minLeft = j + 1 == m ? int.MaxValue : grid[i][j + 1];
            var minTop = i + 1 == n ? int.MaxValue : grid[i + 1][j];
            var min = Math.Min(minLeft, minTop);
            grid[i][j] += min == int.MaxValue ? 0 : min;
        }

        return grid[0][0];
    }
}