namespace Refactoring.UnitTest.Refactroring.CommandExecution.Commands;

using Refactoring.CommandExecution;
using Refactoring.CommandExecution.Commands;
using Refactoring.Commands;

[TestClass]
public class CreateTriangleCommandTests
{
    [TestMethod]
    [DataRow(13, 34, 221)]
    [DataRow(0, 34, 0)]
    [DataRow(34, 0, 0)]
    public void Invoke_AddsTriangleWithCorrectSurfaceArea(double height, double baseLength, double expected)
    {
        var sut = new CreateTriangleCommand();
        var context = new CommandContext(default!);

        sut.Invoke(context, new[] { "create", "triangle", height.ToString(), baseLength.ToString() });

        Assert.AreEqual(1, context.Shapes.Count);
        var actual = context.Shapes[0];
        Assert.AreEqual("Triangle", actual.Name);
        Assert.AreEqual(expected, actual.SurfaceArea);
    }
}