using System;

class Program
{
    static void Main()
    {
        // Create a 2D array to represent the game board
        char[,] board =
        {
            { '+', '-', '-', '-', '-', '-', '-', '-', '+', ' ', ' ', ' ', '+', '-', '-', '-', '-', '-', '+' },
            { '|', ' ', '|', ' ', '|', ' ', '|', ' ', '|', ' ', ' ', ' ', '|', ' ', '|', ' ', '|', ' ', '|' },
            { '|', '-', '-', '-', '-', '-', '-', '-', '-', '-', '-', '-', '-', '-', '-', '-', '-', '-', '|' },
            { '|', ' ', '|', ' ', '|', ' ', '|', ' ', '|', ' ', '|', ' ', '|', ' ', '|', ' ', '|', ' ', '|' },
            { '|', '-', '-', '-', '-', '-', '-', '-', '-', '-', '-', '-', '-', '-', '-', '-', '-', '-', '|' },
            { '|', ' ', '|', ' ', '|', ' ', '|', ' ', '|', ' ', ' ', ' ', '|', ' ', '|', ' ', '|', ' ', '|' },
            { '+', '-', '-', '-', '-', '-', '-', '-', '+', ' ', ' ', ' ', '+', '-', '-', '-', '-', '-', '+' }
        };

        // Display the game board in the console
        for (int row = 0; row < board.GetLength(0); row++)
        {
            for (int col = 0; col < board.GetLength(1); col++)
            {
                Console.Write(board[row, col]);
                Console.Write(' ');
            }
            Console.WriteLine();
        }

        // Wait for user input before closing the console window
        Console.ReadLine();
    }
}

