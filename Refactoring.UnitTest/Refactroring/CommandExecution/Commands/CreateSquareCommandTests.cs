namespace Refactoring.UnitTest.Refactroring.CommandExecution.Commands;

using Refactoring.CommandExecution;
using Refactoring.CommandExecution.Commands;
using Refactoring.Commands;

[TestClass]
public class CreateSquareCommandTests
{
    [TestMethod]
    [DataRow(17, 289)]
    [DataRow(0, 0)]
    public void Invoke_AddsSquareWithCorrectSurfaceArea(double side, double expected)
    {
        var sut = new CreateSquareCommand();
        var context = new CommandContext(default!);

        sut.Invoke(context, new[] { "create", "square", side.ToString() });

        Assert.AreEqual(1, context.Shapes.Count);
        var actual = context.Shapes[0];
        Assert.AreEqual("Square", actual.Name);
        Assert.AreEqual(expected, actual.SurfaceArea);
    }
}