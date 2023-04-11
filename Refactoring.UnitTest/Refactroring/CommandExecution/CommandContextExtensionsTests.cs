namespace Refactoring.UnitTest.Refactroring.CommandExecution;

using Refactoring.CommandExecution;
using Refactoring.Commands;

[TestClass]
public class CommandContextExtensionsTests
{
    public void WriteLine_WritesLineToTextWriter()
    {
        var writer = new StringWriter();
        var commands = new Dictionary<string, ICommand>();
        var context = new CommandContext(commands) { Out = writer };

        CommandContextExtensions.WriteLine(context, "Some text");

        Assert.IsTrue(writer.ToString().Contains("Some text"));
    }

    public void AddShape_AddsShape()
    {
        var writer = new StringWriter();
        var commands = new Dictionary<string, ICommand>();
        var context = new CommandContext(commands) { Out = writer };

        CommandContextExtensions.AddShape(context, default!, default);

        Assert.IsTrue(writer.ToString().Contains("Name created!"));
        Assert.AreEqual(1, context.Shapes.Count);
    }

    [TestMethod]
    public void ListCommands()
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

        CommandContextExtensions.ListCommands(context);
        var actual = writer.ToString();

        Assert.IsTrue(actual.Contains("MyCommandDescription1"));
        Assert.IsTrue(actual.Contains("MyCommandDescription2"));
    }
}
