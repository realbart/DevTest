namespace Refactoring.UnitTest.Refactroring.CommandExecution;

using Refactoring.CommandExecution;
using Refactoring.Commands;

[TestClass]
public class CommandInvokerTests
{
    [TestMethod]
    public void Invoke_ListsCommands_WhenInvocatedCommandWasNotFound()
    {
        var writer = new StringWriter();
        var mocker = new AutoMocker();
        mocker.GetMock<ICommand>().Setup(m => m.Description).Returns("MyCommandDescription");
        var commands = new Dictionary<string, ICommand>
        {
            { "command",mocker.Get<ICommand>() }
        };
        var context = new CommandContext(commands) { Out = writer };
        mocker.Use(context);
        var sut = mocker.CreateInstance<CommandInvoker>();

        sut.Invoke(context, "notfound");

        Assert.IsTrue(writer.ToString().Contains("MyCommandDescription"));
    }

    [TestMethod]
    public void Invoke_InvokesCommand_WithParameters()
    {
        var mocker = new AutoMocker();
        var commands = new Dictionary<string, ICommand>
        {
            { "my command",mocker.Get<ICommand>() }
        };
        var context = new CommandContext(commands) { Continue = false };
        mocker.Use(context);
        var sut = mocker.CreateInstance<CommandInvoker>();

        sut.Invoke(context, "my command with parameters");

        mocker.GetMock<ICommand>().Verify(c => c.Invoke(context, new[] { "my", "command", "with", "parameters" }), Times.Once);
    }

    [TestMethod]
    public void Invoke_InvokesCommand_WithoutParameters()
    {
        var mocker = new AutoMocker();
        var commands = new Dictionary<string, ICommand>
        {
            { "command", mocker.Get<ICommand>() }
        };
        var context = new CommandContext(commands) { Continue = false };
        mocker.Use(context);
        var sut = mocker.CreateInstance<CommandInvoker>();

        sut.Invoke(context, "command");

        mocker.GetMock<ICommand>().Verify(c => c.Invoke(context, new[] { "command" }), Times.Once);
    }
}
