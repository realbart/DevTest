namespace Refactoring.UnitTest.Refactoring.Services.SurfaceCalculation;

using Microsoft.VisualStudio.TestTools.UnitTesting;

public class RectangleTests
{
    private const double RectangleHeight = 23d;
    private const double RectangleWidth = 67d;
    private const double RectangleSurfaceArea = 1541d;

    [TestMethod]
    public void RectangleCalculateSurfaceArea()
    {
        Rectangle sut = new(
            Height: RectangleHeight,
            Width: RectangleWidth
        );

        var actual = sut.CalculateSurfaceArea();

        Assert.AreEqual(RectangleSurfaceArea, actual);
    }
}