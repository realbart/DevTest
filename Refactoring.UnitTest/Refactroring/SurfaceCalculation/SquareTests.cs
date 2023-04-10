namespace Refactoring.UnitTest.Refactroring.SurfaceCalculation;

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Refactoring.SurfaceCalculation;

[TestClass]
public class SquareTests
{
    [TestMethod]
    [DataRow(17d, 289d)]
    [DataRow(0d, 0d)]
    public void SquareCalculateSurfaceArea(double side, double expected)
    {
        Square sut = new(
            Side: side
        );

        var actual = sut.CalculateSurfaceArea();

        Assert.AreEqual(expected, actual);
    }
}
