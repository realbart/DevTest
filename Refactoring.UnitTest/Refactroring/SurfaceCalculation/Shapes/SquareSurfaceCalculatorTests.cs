namespace Refactoring.UnitTest.Refactroring.SurfaceCalculation.Shapes;

using Refactoring.SurfaceCalculation.Shapes;

[TestClass]
public class SquareSurfaceCalculatorTests
{
    [TestMethod]
    [DataRow(17, 289)]
    [DataRow(0, 0)]
    public void SquareCalculateSurfaceArea(double side, double expected)
    {
        SquareSurfaceCalculator sut = new(
            Side: side
        );

        var actual = sut.CalculateSurfaceArea();

        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void Name_ReturnsShapeName()
    {
        SquareSurfaceCalculator sut = new(0);

        Assert.AreEqual("Square", sut.Name);
    }
}
