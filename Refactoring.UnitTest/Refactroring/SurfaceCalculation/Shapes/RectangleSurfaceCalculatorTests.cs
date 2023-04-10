namespace Refactoring.UnitTest.Refactroring.SurfaceCalculation.Shapes;

using Refactoring.SurfaceCalculation.Shapes;

[TestClass]
public class RectangleSurfaceCalculatorTests
{
    [TestMethod]
    [DataRow(23, 67, 1541)]
    [DataRow(0, 67, 0)]
    [DataRow(23, 0, 0)]
    public void RectangleCalculateSurfaceArea(double height, double width, double expected)
    {
        RectangleSurfaceCalculator sut = new(
            Height: height,
            Width: width
        );

        var actual = sut.CalculateSurfaceArea();

        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void Name_ReturnsShapeName()
    {
        RectangleSurfaceCalculator sut = new(0, 0);

        Assert.AreEqual("Rectangle", sut.Name);
    }
}