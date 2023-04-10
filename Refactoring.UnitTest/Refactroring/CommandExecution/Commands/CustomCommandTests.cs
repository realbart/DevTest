namespace Refactoring.UnitTest.Refactroring.CommandExecution.Commands;

using Refactoring.CommandExecution;
using Refactoring.CommandExecution.Commands;
using Refactoring.Commands;

[TestClass]
public class CustomCommandTests
{
    [TestMethod]
    public void Invoke_InvokesDelegate()
    {
        var commands = new Dictionary<string, ICommand>();
        var expected1 = new CommandContext(commands);
        var expected2 = new[] { "one", "two" };

        CommandContext actual1 = default!;
        string[] actual2 = default!;

        var sut = new CustomCommand(default!, default!, (context, parms) => {
            actual1 = context;
            actual2 = parms;
            });

        sut.Invoke(expected1, expected2 );

        Assert.AreEqual(expected1, actual1);
        Assert.AreEqual(expected2, actual2);
    }
}