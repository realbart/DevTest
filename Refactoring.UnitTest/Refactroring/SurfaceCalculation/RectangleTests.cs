namespace Refactoring.UnitTest.Refactroring.SurfaceCalculation;

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Refactoring.SurfaceCalculation;

[TestClass]
public class RectangleTests
{
    [TestMethod]
    [DataRow(23d, 67d, 1541d)]
    [DataRow(0, 67d, 0d)]
    [DataRow(23d, 0d, 0d)]
    public void RectangleCalculateSurfaceArea(double height, double width, double expected)
    {
        Rectangle sut = new(
            Height: height,
            Width: width
        );

        var actual = sut.CalculateSurfaceArea();

        Assert.AreEqual(expected, actual);
    }
}