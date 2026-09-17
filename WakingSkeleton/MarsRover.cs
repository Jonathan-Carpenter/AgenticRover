namespace WakingSkeleton;

public enum Heading
{
    North
}

public readonly record struct Position(int X, int Y);

public sealed class MarsRover
{
    public MarsRover(Position position, Heading heading)
    {
        Position = position;
        Heading = heading;
    }

    public Position Position { get; }

    public Heading Heading { get; }
}