namespace Refactoring.UnitTest.Refactroring.CommandExecution.Commands;

using Refactoring.CommandExecution;
using Refactoring.CommandExecution.Commands;
using Refactoring.Commands;

[TestClass]
public class CreateRectangleCommandTests
{
    [TestMethod]
    [DataRow(23, 67, 1541)]
    [DataRow(0, 67, 0)]
    [DataRow(23, 0, 0)]
    public void Invoke_AddsRectangleWithCorrectSurfaceArea(double height, double width, double expected)
    {
        var sut = new CreateRectangleCommand();
        var context = new CommandContext(default!);

        sut.Invoke(context, new[] { "create", "rectangle", height.ToString(), width.ToString() });

        Assert.AreEqual(1, context.Shapes.Count);
        var actual = context.Shapes[0];
        Assert.AreEqual("Rectangle", actual.Name);
        Assert.AreEqual(expected, actual.SurfaceArea);
    }
}