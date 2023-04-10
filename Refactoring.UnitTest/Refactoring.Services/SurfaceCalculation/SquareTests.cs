namespace Refactoring.UnitTest.Refactoring.Services.SurfaceCalculation;

using Microsoft.VisualStudio.TestTools.UnitTesting;

public class SquareTests
{

    private const double SquareSide = 17d;
    private const double SquareSurfaceArea = 289d;

    [TestMethod]
    public void SquareCalculateSurfaceArea()
    {
        // Arrange
        Square sut = new(
            Side: SquareSide
        );

        // Act
        var actual = sut.CalculateSurfaceArea();

        // Assert
        Assert.AreEqual(SquareSurfaceArea, actual);
    }
}
