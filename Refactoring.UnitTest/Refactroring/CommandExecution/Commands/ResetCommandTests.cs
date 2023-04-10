namespace Refactoring.UnitTest.Refactroring.CommandExecution.Commands;

using Refactoring.CommandExecution;
using Refactoring.CommandExecution.Commands;
using Refactoring.Commands;
using Refactoring.SurfaceCalculation;

[TestClass]
public class ResetCommandTests
{
    [TestMethod]
    public void Invoke_RemovesShapesFromContext()
    {
        var commands = new Dictionary<string, ICommand>();
        var shape = new Mock<ISurface>().Object;
        var context = new CommandContext(commands);
        context.Shapes.Add(shape);
        context.Shapes.Add(shape);

        var sut = new ResetCommand();

        sut.Invoke(context, default!);

        Assert.AreEqual(0, context.Shapes.Count);
    }
}