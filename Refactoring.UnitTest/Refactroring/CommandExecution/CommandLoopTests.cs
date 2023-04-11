namespace Refactoring.UnitTest.Refactroring.CommandExecution;

using Refactoring.CommandExecution;
using Refactoring.Commands;
using Thinktecture;

[TestClass]
public class CommandLoopTests
{
    [TestMethod]
    public void Start_DisplaysCommandDescription()
    {
        var writer = new StringWriter();
        var mocker = new AutoMocker();
        mocker.GetMock<ICommand>().Setup(m => m.Description).Returns("MyCommandDescription");
        var commands = new Dictionary<string, ICommand>
        {
            { "",mocker.Get<ICommand>() }
        };
        var context = new CommandContext(commands) { Out = writer, Continue = false };
        mocker.Use(context);
        var sut = mocker.CreateInstance<CommandLoop>();

        sut.Start();

        Assert.IsTrue(writer.ToString().Contains("MyCommandDescription"));
    }

    [TestMethod]
    public void Start_CallsExecuteWithCommandLine()
    {
        var commands = new Dictionary<string, ICommand>();
        var context = new CommandContext(commands);
        var mocker = new AutoMocker();
        mocker.Use(context);
        mocker.GetMock<IConsole>().Setup(c => c.ReadLine()).Returns(() =>
        {
            context.Continue = false;
            return "cmd";
        });
        var sut = mocker.CreateInstance<CommandLoop>();

        sut.Start();

        mocker.GetMock<ICommandInvoker>().Verify(x => x.Invoke(context, "cmd"), Times.Once);
    }
}