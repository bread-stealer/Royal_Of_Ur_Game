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
        public const int MaxPosition = 8;

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

    private static void UpdatePlayerSymbol(char[,] board, Player player, char symbol)
    {
        int position = player.Position;

        if (position == 1)
            board[1, 11] = symbol; // Update the 'S' position on the board
        else if (position == MaxPosition) // Check if player reached the end
            board[1, 17] = symbol; // Update the 'E' position on the board
        else
        {
            int row = GetRow(position);
            int col = GetColumn(position);

            if (IsValidPosition(row, col))
                board[row, col] = symbol;
        }
    }

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

    private static bool IsValidPosition(int row, int col)
    {
        return row >= 0 && row < board.GetLength(0) && col >= 0 && col < board.GetLength(1);
    }
}
