using System;

class Program
{
    static void Main()
    {
        GameBoard.DisplayBoard();

        Player player1 = new Player("Player 1");
        Player player2 = new Player("Player 2");

        Console.WriteLine("Player 1: " + player1.Name);
        Console.WriteLine("Player 2: " + player2.Name);

        // Wait for user input before closing the console window
        Console.ReadLine();
    }
}
