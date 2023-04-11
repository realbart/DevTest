namespace Refactoring.UnitTest.Refactroring.CommandExecution.Commands;

using Refactoring.CommandExecution;
using Refactoring.CommandExecution.Commands;
using Refactoring.Commands;

[TestClass]
public class CreateCommandTests
{
    [TestMethod]
    public void Invoke_ListsCommands()
    {
        var writer = new StringWriter();
        var commandMock1 = new Mock<ICommand>();
        commandMock1.Setup(m => m.Description).Returns("MyCommandDescription1");
        var commandMock2 = new Mock<ICommand>();
        commandMock2.Setup(m => m.Description).Returns("MyCommandDescription2");
        var commands = new Dictionary<string, ICommand>
        {
            { "1", commandMock1.Object },
            { "2", commandMock2.Object }
        };
        var context = new CommandContext(commands) { Out = writer };
        var sut = new CreateCommand();

        sut.Invoke(context, new[] { "create" });

        var actual = writer.ToString();
        Assert.IsTrue(actual.Contains("MyCommandDescription1"));
        Assert.IsTrue(actual.Contains("MyCommandDescription2"));
    }
}