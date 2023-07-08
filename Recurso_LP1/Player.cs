using System;

public class Player
{
    private const int MaxPosition = 8;

    public string Name { get; private set; }
    public int Position { get; private set; }

    public Player(string name)
    {
        Name = name;
        Position = -1;
    }

    public void Move(int diceNumber, Player opponent)
    {
        if (Position == -1)
        {
            if (diceNumber == 1)
            {
                Position = 1;
                Console.WriteLine(Name + " started the game.");
            }
            else
            {
                Console.WriteLine("Invalid move. " + Name + " needs a dice number of 1 to start.");
            }
        }
        else
        {
            int newPosition = Position + diceNumber;

            if (newPosition <= MaxPosition)
            {
                if (opponent != null && newPosition == opponent.Position)
                {
                    Console.WriteLine(Name + " captured opponent's piece!");
                    opponent.ResetPosition();
                }
                Position = newPosition;
            }
            else
            {
                Position = MaxPosition;
                Console.WriteLine(Name + " reached the end!");
            }
        }
    }

    public void ResetPosition()
    {
        Position = -1;
        Console.WriteLine(Name + " returned to the starting position.");
    }
}

