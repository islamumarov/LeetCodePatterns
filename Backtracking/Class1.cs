namespace Backtracking;

public class WordSearch
{
    public bool Exist(char[][] board, string word)
    {
        var words = new List<List<string>>();
        for (int i = 0; i < board.Length; i++)
        {
            for (int j = 0; j < board[i].Length; j++)
            {
                words.Add(new List<string>());
            }
        }
    }
}