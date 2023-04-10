namespace Refactoring.UnitTest.Refactoring.Services.SurfaceCalculation;

using Microsoft.VisualStudio.TestTools.UnitTesting;

public class CircleTests
{
    private const double CircleRadius = 23d;
    private const double CircleSurfaceArea = 1661.9d;

    [TestMethod]
    public void CircleCalculateSurfaceArea()
    {
        Circle sut = new(
            Radius: CircleRadius
        );

        var actual = sut.CalculateSurfaceArea();

        Assert.AreEqual(CircleSurfaceArea, actual);
    }
}
