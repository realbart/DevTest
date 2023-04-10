namespace Refactoring.UnitTest.Refactroring.CommandExecution.Commands;

using Refactoring.CommandExecution;
using Refactoring.CommandExecution.Commands;
using Refactoring.Commands;

[TestClass]
public class CreateSquareCommandTests
{
    [TestMethod]
    public void Invoke_AddsSquareToContext()
    {
        var commands = new Dictionary<string, ICommand>();
        var context = new CommandContext(commands);
        var sut = new CreateSquareCommand();

        sut.Invoke(context, new[] { "create", "square", "0" });

        Assert.AreEqual(1, context.Shapes.Count);
    }
}