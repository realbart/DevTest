namespace Refactoring.UnitTest.Refactroring;

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Refactoring.SurfaceCalculation;

[TestClass]
public class UnitTest
{
    [TestMethod]
    public void CalculateSurfaceAreas_PopulatesSurfaceAreasCollection()
    {
        var expectedSurfaceArea1 = 5d;
        var expectedSurfaceArea2 = 6.66d;

        var surfaceCalculatorMock1 = new Mock<ISurface>();
        surfaceCalculatorMock1.Setup(s => s.CalculateSurfaceArea()).Returns(expectedSurfaceArea1);
        var surfaceCalculatorMock2 = new Mock<ISurface>();
        surfaceCalculatorMock2.Setup(s => s.CalculateSurfaceArea()).Returns(expectedSurfaceArea2);
        var sut = new SurfaceAreaCalculator();
        sut.Shapes.Add(surfaceCalculatorMock1.Object);
        sut.Shapes.Add(surfaceCalculatorMock2.Object);

        sut.CalculateSurfaceAreas();
        var actual = sut.SurfaceAreas;

        Assert.AreEqual(2, actual.Count);
        Assert.AreEqual(expectedSurfaceArea1, actual[0]);
        Assert.AreEqual(expectedSurfaceArea2, actual[1]);
    }
}
