namespace WakingSkeleton.Test;

[TestFixture]
public class MovingTheMarsRoverBackwardTests
{
    [TestCase(Heading.North, 1, 0)]
    [TestCase(Heading.East, 0, 1)]
    [TestCase(Heading.South, 1, 2)]
    [TestCase(Heading.West, 2, 1)]
    public void MovingBackwardChangesPositionOppositeToHeading(Heading direction, int expectedX, int expectedY)
    {
        var rover = new MarsRover(new Position(1, 1), direction);

        rover.Receive("B");

        Assert.That(rover.Position, Is.EqualTo(new Position(expectedX, expectedY)));
    }
}