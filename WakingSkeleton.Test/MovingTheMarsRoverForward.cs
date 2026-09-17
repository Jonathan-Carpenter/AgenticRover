namespace WakingSkeleton.Test;

[TestFixture]
public class MovingTheMarsRoverForward
{
    [TestCase(Heading.North, 1, 2)]
    [TestCase(Heading.East, 2, 1)]
    [TestCase(Heading.South, 1, 0)]
    [TestCase(Heading.West, 0, 1)]
    public void MovingForwardChangesPositionBasedOnHeading(Heading direction, int expectedX, int expectedY)
    {
        var rover = new MarsRover(new Position(1, 1), direction);

        rover.Receive("F");

        Assert.That(rover.Position, Is.EqualTo(new Position(expectedX, expectedY)));
    }
}
