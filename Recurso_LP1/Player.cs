using System;

public class Player
{
    private const int MaxPosition = 8;
    private const int MinPosition = 0;

    public string Name { get; private set; }
    public int Position { get; private set; }

    public Player(string name)
    {
        Name = name;
        Position = 0;
    }

    public void Move(int diceNumber)
    {
        int newPosition = Position + diceNumber;

        if (newPosition <= MaxPosition)
            Position = newPosition;
        else
            Position = MaxPosition;
    }
}
