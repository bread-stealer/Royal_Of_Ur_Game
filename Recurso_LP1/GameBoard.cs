using System;

/// <summary>
/// Represents the game board for the Royal Game of Ur.
/// </summary>
class GameBoard
{
    private char[,] board;

    /// <summary>
    /// Initializes a new instance of the GameBoard class.
    /// </summary>
    public GameBoard()
    {
        board = new char[3, 7];
        InitializeBoard();
    }

    /// <summary>
    /// Initializes the game board with empty spaces.
    /// </summary>
    private void InitializeBoard()
    {
        for (int row = 0; row < 3; row++)
        {
            for (int col = 0; col < 7; col++)
            {
                board[row, col] = ' ';
            }
        }
    }

    /// <summary>
    /// Displays the game board on the console.
    /// </summary>
    public void DisplayBoard()
    {
        Console.Clear();
        Console.WriteLine(" {0} | {1} | {2} | {3} |   | {4} | {5} | {6} ", board[0, 0], board[0, 1], board[0, 2], board[0, 3], board[0, 4], board[0, 5], board[0, 6]);
        Console.WriteLine("---|---|---|---|---|---|---");
        Console.WriteLine(" {0} | {1} | {2} | {3} | {4} | {5} | {6} | {7} ", board[1, 0], board[1, 1], board[1, 2], board[1, 3], board[1, 4], board[1, 5], board[1, 6], board[2, 0]);
        Console.WriteLine("---|---|---|---|---|---|---");
        Console.WriteLine(" {0} | {1} | {2} | {3} |   | {4} | {5} | {6} ", board[2, 1], board[2, 2], board[2, 3], board[2, 4], board[2, 5], board[2, 6], board[1, 7]);
    }

    /// <summary>
    /// Sets the value of a specific cell on the game board.
    /// </summary>
    /// <param name="row">The row index of the cell.</param>
    /// <param name="col">The column index of the cell.</param>
    /// <param name="value">The value to set in the cell.</param>
    public void SetCellValue(int row, int col, char value)
    {
        board[row, col] = value;
    }

    /// <summary>
    /// Gets the value of a specific cell on the game board.
    /// </summary>
    /// <param name="row">The row index of the cell.</param>
    /// <param name="col">The column index of the cell.</param>
    /// <returns>The value of the cell.</returns>
    public char GetCellValue(int row, int col)
    {
        return board[row, col];
    }
}
