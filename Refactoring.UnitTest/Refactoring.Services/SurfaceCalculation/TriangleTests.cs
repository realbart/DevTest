namespace Refactoring.UnitTest.Refactoring.Services.SurfaceCalculation;

using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass]
public class TriangleTests
{
    private const double TriangleHeight = 13d;
    private const double TriangleWidth = 34d;
    private const double TriangleSurfaceArea = 221d;


    [TestMethod]
    public void TriangleCalculateSurfaceArea()
    {
        Triangle sut = new(
            Height: TriangleHeight,
            Base: TriangleWidth
        );

        double actual = sut.CalculateSurfaceArea();

        Assert.AreEqual(TriangleSurfaceArea, actual);
    }
}
