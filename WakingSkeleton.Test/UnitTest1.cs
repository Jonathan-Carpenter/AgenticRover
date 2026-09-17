namespace WakingSkeleton.Test;

public class InitialiseRoverAtAGivenPositionAndDirection
{
    private readonly MarsRover rover = new(new Position(2, 3), Heading.North);

    [Test]
    public void RoverPositionShouldBeTwoThree()
    {
        Assert.That(rover.Position, Is.EqualTo(new Position(2, 3)));
    }

    [Test]
    public void RoverHeadingShouldBeNorth()
    {
        Assert.That(rover.Heading, Is.EqualTo(Heading.North));
    }
}