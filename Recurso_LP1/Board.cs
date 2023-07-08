using System;
class GameBoard
{
    private static char[,] board =
    {
        { '+','-', '-', '-', '-', '-', '-', '-', '-', '-', '-', '+', ' ', ' ', ' ', ' ', '+', '-', '-', '-','-','-', '+',},
        { '|',' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ',' ',' ', '|',},
        { '+',' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '+', '-', '-', '-', '-', '+', ' ', ' ', ' ',' ',' ', '+',},
        { '|',' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ',' ',' ', '|',},
        { '+',' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '+', '-', '-', '-', '-', '+', ' ', ' ', ' ',' ',' ', '+',},
        { '|',' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|', ' ', ' ', ' ', ' ', '|', ' ', ' ', ' ',' ',' ', '|',},
        { '+','-', '-', '-', '+', '-', '-', '-', '-', '-', '-', '+', ' ', ' ', ' ', ' ', '+', '-', '-', '-','-','-', '+',}
    };
    /// <summary>
    /// The maximum position on the game board.
    /// </summary>
    public const int MaxPosition = 8;

    /// <summary>
    /// Displays the game board with player positions.
    /// </summary>
    /// <param name="player1">The first player.</param>
    /// <param name="player2">The second player.</param>
    public static void DisplayBoard(Player player1 = null, Player player2 = null)
    {
        char[,] boardCopy = (char[,])board.Clone();

        if (player1 != null)
            UpdatePlayerSymbol(boardCopy, player1, '1');

        if (player2 != null)
            UpdatePlayerSymbol(boardCopy, player2, '2');

        for (int row = 0; row < boardCopy.GetLength(0); row++)
        {
            for (int col = 0; col < boardCopy.GetLength(1); col++)
            {
                Console.Write(boardCopy[row, col]);
            }
            Console.WriteLine();
        }

        if (player1 != null)
            Console.WriteLine("Player 1 position: " + player1.Position);

        if (player2 != null)
            Console.WriteLine("Player 2 position: " + player2.Position);
    }

    /// <summary>
    /// Updates the symbol of a player on the game board.
    /// </summary>
    /// <param name="board">The game board.</param>
    /// <param name="player">The player.</param>
    /// <param name="symbol">The symbol to update.</param>
    private static void UpdatePlayerSymbol(char[,] board, Player player, char symbol)
    {
        int position = player.Position;

        if (position == 1)
            board[1, 11] = symbol;
        else if (position == MaxPosition)
            board[1, 17] = symbol;
        else
        {
            int row = GetRow(position);
            int col = GetColumn(position);

            if (IsValidPosition(row, col))
                board[row, col] = symbol;
        }
    }
    
    /// <summary>
    /// Gets the row index on the game board based on the player's position.
    /// </summary>
    /// <param name="position">The player's position.</param>
    /// <returns>The row index.</returns>
    private static int GetRow(int position)
    {
        return position / 3 * 2 + 1;
    }

    private static int GetColumn(int position)
    {
        int row = GetRow(position);
        int col;

        if (row % 2 == 0)
            col = 2 + (position % 3) * 4;
        else
            col = 4 + (position % 3) * 4;

        return col;
    }
    /// <summary>
    /// Checks if the specified row and column indices represent a valid position on the game board.
    /// </summary>
    /// <param name="row">The row index.</param>
    /// <param name="col">The column index.</param>
    /// <returns>True if the position is valid; otherwise, false.</returns>
    private static bool IsValidPosition(int row, int col)
    {
        return row >= 0 && row < board.GetLength(0) && col >= 0 && col < board.GetLength(1);
    }
}