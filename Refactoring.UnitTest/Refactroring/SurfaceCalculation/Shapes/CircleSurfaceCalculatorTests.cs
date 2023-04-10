namespace Refactoring.UnitTest.Refactroring.SurfaceCalculation.Shapes;

using Refactoring.SurfaceCalculation.Shapes;
using System.Runtime.CompilerServices;

[TestClass]
public class CircleSurfaceCalculatorTests
{
    [TestMethod]
    [DataRow(0, 0)]
    [DataRow(23, 1661.9)]
    [DataRow(1.7881338894826018, 10.04)]
    [DataRow(1.7872436061864481, 10.04)]
    public void CircleCalculateSurfaceArea_CalculatesAndRoundsCorrectly(double radius, double expected)
    {
        CircleSurfaceCalculator sut = new(
            Radius: radius
        );

        var actual = sut.CalculateSurfaceArea();

        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void Name_ReturnsShapeName()
    {
        CircleSurfaceCalculator sut = new(0);

        Assert.AreEqual("Circle", sut.Name);
    }
}
