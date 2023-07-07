using System;

/// <summary>
/// Represents a game board.
/// </summary>
class GameBoard
{
    private char[,] board;

    public GameBoard()
    {
        board = new char[3, 7];
    }

    public void DisplayBoard()
    {
        for (int row = 0; row < 3; row++)
        {
            for (int col = 0; col < 7; col++)
            {
                Console.Write(board[row, col]);
            }
            Console.WriteLine();
        }
    }

    public void SetCellValue(int row, int col, char value)
    {
        board[row, col] = value;
    }
}
