namespace Refactoring.UnitTest.Refactroring.CommandExecution.Commands;

using Refactoring.CommandExecution;
using Refactoring.CommandExecution.Commands;
using Refactoring.Commands;
using Refactoring.Models;

[TestClass]
public class ResetCommandTests
{
    [TestMethod]
    public void Invoke_RemovesShapesFromContext()
    {
        var commands = new Dictionary<string, ICommand>();
        var shape = new Shape(default!, default);
        var context = new CommandContext(commands);
        context.Shapes.Add(shape);
        context.Shapes.Add(shape);
        var sut = new ResetCommand();

        sut.Invoke(context, default!);

        Assert.AreEqual(0, context.Shapes.Count);
    }
}