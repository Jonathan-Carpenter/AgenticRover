namespace WakingSkeleton;

public enum Heading
{
    North,
    East,
    South,
    West
}

public readonly record struct Position(int X, int Y);

public sealed class MarsRover
{
    public MarsRover(Position position, Heading heading)
    {
        Position = position;
        Heading = heading;
    }

    public Position Position { get; private set; }

    public Heading Heading { get; }

    public void Receive(string command)
    {
        if (command == "F")
        {
            Position = Heading switch
            {
                Heading.North => Position with { Y = Position.Y + 1 },
                Heading.East => Position with { X = Position.X + 1 },
                Heading.South => Position with { Y = Position.Y - 1 },
                Heading.West => Position with { X = Position.X - 1 },
                _ => Position
            };
        }

        if (command == "B")
        {
            Position = Heading switch
            {
                Heading.North => Position with { Y = Position.Y - 1 },
                Heading.East => Position with { X = Position.X - 1 },
                Heading.South => Position with { Y = Position.Y + 1 },
                Heading.West => Position with { X = Position.X + 1 },
                _ => Position
            };
        }
    }
}