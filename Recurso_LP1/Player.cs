using System;

/// <summary>
/// Represents a player in the game.
/// </summary>
class Player
{
    /// <summary>
    /// Gets the name of the player.
    /// </summary>
    public string Name { get; private set; }

    /// <summary>
    /// Gets the symbol representing the player's moves on the game board.
    /// </summary>
    public char Symbol { get; private set; }

    /// <summary>
    /// Initializes a new instance of the Player class with the specified name and symbol.
    /// </summary>
    /// <param name="name">The name of the player.</param>
    /// <param name="symbol">The symbol representing the player's moves.</param>
    public Player(string name, char symbol)
    {
        Name = name;
        Symbol = symbol;
    }

    /// <summary>
    /// Performs the player's move in the game.
    /// </summary>
    public void MakeMove()
    {
        Console.WriteLine("{0}, it's your turn. Make your move!", Name);
    }
}
