using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Arrays;

public class WordSearch
{
    public static bool Exist(char[][] board, string word)
    {
        var direction = new int[][] { [0, -1], [0, 1], [-1, 0], [1, 0] }; 
        
        bool Dfs(int i, int j, int s)
        {
            if (s == word.Length)
            {
                return true;
            }
            if (i < 0 || i >= board.Length || j < 0 || j >= board[0].Length || board[i][j] != word[s])
            {
                return false;
            }
            var temp = board[i][j];
            board[i][j] = '#'; // Mark as visited
            foreach (var d in direction)
            {
                if (Dfs(i + d[0], j + d[1], s + 1))
                {
                    return true;
                }
            }
            board[i][j] = temp; // Unmark
            return false;
        }

        for (int i = 0; i < board.Length; i++)
        {
            for (int j = 0; j < board[0].Length; j++)
            {
                if (board[i][j] == word[0] && Dfs(i, j, 0))
                {
                    return true;
                }
            }
        }

        return false;
    }
}
