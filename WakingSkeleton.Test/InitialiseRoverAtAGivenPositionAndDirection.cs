namespace WakingSkeleton.Test;

[TestFixture]
public class InitialiseRoverAtAGivenPositionAndDirection
{
    private readonly MarsRover rover = new(new Position(2, 3), Heading.North);

    [Test]
    public void InitializeRoverAtGivenPosition()
    {
        Assert.That(rover.Position, Is.EqualTo(new Position(2, 3)));
    }

    [Test]
    public void InitializeRoverWithGivenHeading()
    {
        Assert.That(rover.Heading, Is.EqualTo(Heading.North));
    }
}