namespace Refactoring.UnitTest.Refactroring.CommandExecution;

using Refactoring.Commands;

[TestClass]
public class CommandContextTests
{
    [TestMethod]
    public void Create_CreateCommandContextWithCommands()
    {
        var actual = CommandContext.Create();

        Assert.IsTrue(actual.Commands.ContainsKey("create square"));
        Assert.IsTrue(actual.Commands.ContainsKey("create circle"));
        Assert.IsTrue(actual.Commands.ContainsKey("create rectangle"));
        Assert.IsTrue(actual.Commands.ContainsKey("create triangle"));
        Assert.IsTrue(actual.Commands.ContainsKey("calculate"));
        Assert.IsTrue(actual.Commands.ContainsKey("print"));
        Assert.IsTrue(actual.Commands.ContainsKey("reset"));
        Assert.IsTrue(actual.Commands.ContainsKey("exit"));
        Assert.IsTrue(actual.Commands.ContainsKey("create rhombus"));
    }
}
