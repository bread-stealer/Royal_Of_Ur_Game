using System;

public class Program
{
    /// <summary>
    /// The main entry point of the program.
    /// </summary>
    static void Main()
    {
        Console.WriteLine();
        GameBoard.DisplayBoard();
        Console.WriteLine();

        // Prompt for player names
        Console.WriteLine("Enter the name for Player 1:");
        string player1Name = Console.ReadLine();

        Console.WriteLine("Enter the name for Player 2:");
        string player2Name = Console.ReadLine();

        // Create player instances
        Player player1 = new Player(player1Name);
        Player player2 = new Player(player2Name);

        Console.WriteLine();
        Console.WriteLine("Player 1: " + player1.Name);
        Console.WriteLine("Player 2: " + player2.Name);

        Console.WriteLine();

        Random random = new Random();

        // Generate a random dice number between 1 and 6
        int diceNumber = random.Next(1, 7);

        Console.WriteLine("Dice Number: " + diceNumber);

        Console.WriteLine();

        // Move players
        player1.Move(diceNumber, player2); // Player 1 moves first
        player2.Move(diceNumber, player1); // Player 2 moves second

        Console.WriteLine(player1.Name + " moved to position: " + player1.Position);
        Console.WriteLine(player2.Name + " moved to position: " + player2.Position);

        Console.WriteLine();

        // Display the updated game board
        GameBoard.DisplayBoard(player1, player2);
        Console.WriteLine();
    }
}

