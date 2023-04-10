namespace Refactoring.UnitTest.Refactroring.CommandExecution.Commands;

using Refactoring.CommandExecution;
using Refactoring.CommandExecution.Commands;
using Refactoring.Commands;

[TestClass]
public class CreateTriangleCommandTests
{
    [TestMethod]
    public void Invoke_AddsTriangleToContext()
    {
        var commands = new Dictionary<string, ICommand>();
        var context = new CommandContext(commands);
        var sut = new CreateRectangleCommand();

        sut.Invoke(context, new[] { "create", "triangle", "0", "0" });

        Assert.AreEqual(1, context.Shapes.Count);
    }
}