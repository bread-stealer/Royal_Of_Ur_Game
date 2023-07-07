using System;

class Program
{
    static void Main()
    {
        Console.WriteLine();
        //GameBoard.DisplayBoard();
        Console.WriteLine();

        Console.WriteLine("Enter the name for Player 1:");
        string player1Name = Console.ReadLine();

        Console.WriteLine("Enter the name for Player 2:");
        string player2Name = Console.ReadLine();

        Player player1 = new Player(player1Name);
        Player player2 = new Player(player2Name);

        Console.WriteLine();
        Console.WriteLine("Player 1: " + player1.Name);
        Console.WriteLine("Player 2: " + player2.Name);

        Console.WriteLine();
        Random random = new Random();
        int diceNumber = random.Next(1, 7); // Generate a random dice number between 1 and 6

        Console.WriteLine("Dice Number: " + diceNumber);

        Console.WriteLine();
        player1.Move(diceNumber);
        player2.Move(diceNumber);

        Console.WriteLine(player1.Name + " moved to position: " + player1.Position);
        Console.WriteLine(player2.Name + " moved to position: " + player2.Position);

        Console.WriteLine();
        GameBoard.DisplayBoard(player1, player2);
        Console.WriteLine();
    }
}
