using System;

namespace Recurso_LP1
{
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

            // Modify the board as needed
            gameBoard.SetCellValue(0, 0, 'X');
            gameBoard.SetCellValue(1, 3, 'O');
            gameBoard.SetCellValue(2, 6, 'X');

            gameBoard.DisplayBoard();

            Console.ReadLine();
        }
    }

}
