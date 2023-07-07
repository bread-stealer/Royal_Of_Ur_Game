using System;

/// <summary>
/// Represents the entry point of the program.
/// </summary>
class Program
{
    /// <summary>
    /// The main method of the program.
    /// </summary>
    /// <param name="args">Command-line arguments.</param>
    static void Main(string[] args)
    {
        GameBoard gameBoard = new GameBoard();
        gameBoard.DisplayBoard();

        // Create players
        Player player1 = new Player("Player 1", 'X');
        Player player2 = new Player("Player 2", 'O');

        gameBoard.SetCellValue(0, 0, player1.Symbol);
        gameBoard.SetCellValue(1, 3, player2.Symbol);
        gameBoard.SetCellValue(2, 6, player1.Symbol);

        gameBoard.DisplayBoard();

        // Players make their moves
        player1.MakeMove();
        player2.MakeMove();

        Console.ReadLine();
    }
}