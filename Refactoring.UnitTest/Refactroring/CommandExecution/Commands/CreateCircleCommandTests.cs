namespace Refactoring.UnitTest.Refactroring.CommandExecution.Commands;

using Refactoring.CommandExecution;
using Refactoring.CommandExecution.Commands;
using Refactoring.Commands;

[TestClass]
public class CreateCircleCommandTests
{
    [TestMethod]
    [DataRow(0, 0)]
    [DataRow(23, 1661.9)]
    [DataRow(1.7881338894826018, 10.04)]
    [DataRow(1.7872436061864481, 10.04)]
    public void Invoke_AddsCircleWithCorrectSurfaceArea(double radius, double expected)
    {
        var sut = new CreateCircleCommand();
        var context = new CommandContext(default!);

        sut.Invoke(context, new[] { "create", "circle", radius.ToString() });

        Assert.AreEqual(1, context.Shapes.Count);
        var actual = context.Shapes[0];
        Assert.AreEqual("Circle", actual.Name);
        Assert.AreEqual(expected, actual.SurfaceArea);
    }
}