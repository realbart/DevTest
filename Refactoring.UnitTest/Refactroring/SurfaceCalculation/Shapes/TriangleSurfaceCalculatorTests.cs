namespace Refactoring.UnitTest.Refactroring.SurfaceCalculation.Shapes;

using Refactoring.SurfaceCalculation.Shapes;

[TestClass]
public class TriangleSurfaceCalculatorTests
{
    [TestMethod]
    [DataRow(13, 34, 221)]
    [DataRow(0, 34, 0)]
    [DataRow(34, 0, 0)]
    public void TriangleCalculateSurfaceArea(double height, double @base, double expected)
    {
        TriangleSurfaceCalculator sut = new(
            Height: height,
            Base: @base
        );

        double actual = sut.CalculateSurfaceArea();

        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void Name_ReturnsShapeName()
    {
        TriangleSurfaceCalculator sut = new(0, 0);

        Assert.AreEqual("Triangle", sut.Name);
    }
}
