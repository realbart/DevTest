namespace Refactoring.UnitTest.Refactroring.CommandExecution.Commands;

using Refactoring.CommandExecution;
using Refactoring.CommandExecution.Commands;
using Refactoring.Commands;

[TestClass]
public class CreateCircleCommandTests
{
    [TestMethod]
    public void Invoke_AddsCircleToContext()
    {
        var commands = new Dictionary<string, ICommand>();
        var context = new CommandContext(commands);
        var sut = new CreateCircleCommand();

        sut.Invoke(context, new[] { "create", "circle", "0" });

        Assert.AreEqual(1, context.Shapes.Count);
    }
}