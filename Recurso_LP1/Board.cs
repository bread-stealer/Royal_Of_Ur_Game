using System;

class GameBoard
{
    public static void DisplayBoard()
    {
        Console.WriteLine();
        char[,] board =
        {
            { '+', '-', '-', '-', '-', '-', '-', '-', '+', ' ', ' ', ' ', '+', '-', '-', '-', '+' },
            { '|', ' ', '|', ' ', '|', ' ', '|', ' ', '|', ' ', ' ', ' ', '|', ' ', '|', ' ', '|' },
            { '|', '-', '-', '-', '-', '-', '-', '-', '-', '-', '-', '-', '-', '-', '-', '-', '|' },
            { '|', ' ', '|', ' ', '|', ' ', '|', ' ', '|', ' ', '|', ' ', '|', ' ', '|', ' ', '|' },
            { '|', '-', '-', '-', '-', '-', '-', '-', '-', '-', '-', '-', '-', '-', '-', '-', '|' },
            { '|', ' ', '|', ' ', '|', ' ', '|', ' ', '|', ' ', ' ', ' ', '|', ' ', '|', ' ', '|' },
            { '+', '-', '-', '-', '-', '-', '-', '-', '+', ' ', ' ', ' ', '+', '-', '-', '-', '+' }
        };
        
        for (int row = 0; row < board.GetLength(0); row++)
        {
            for (int col = 0; col < board.GetLength(1); col++)
            {
                Console.Write(board[row, col]);
                Console.Write(' ');
            }
            Console.WriteLine();
        }

        Console.WriteLine();
    }
}
