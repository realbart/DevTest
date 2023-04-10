namespace Refactoring.UnitTest.Refactroring.SurfaceCalculation;

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Refactoring.SurfaceCalculation;

[TestClass]
public class TriangleTests
{
    [TestMethod]
    [DataRow(13d, 34d, 221d)]
    [DataRow(0d, 34d, 0d)]
    [DataRow(34d, 0d, 0d)]
    public void TriangleCalculateSurfaceArea(double height, double @base, double expected)
    {
        Triangle sut = new(
            Height: height,
            Base: @base
        );

        double actual = sut.CalculateSurfaceArea();

        Assert.AreEqual(expected, actual);
    }
}
