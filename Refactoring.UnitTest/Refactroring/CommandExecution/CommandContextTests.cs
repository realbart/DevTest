namespace Refactoring.UnitTest.Refactroring.CommandExecution;

using Refactoring.Commands;

[TestClass]
public class CommandContextTests
{
    [TestMethod]
    public void Create_CreateCommandContextWithCommands()
    {
        var actual = CommandContext.Create();

        Assert.IsTrue(actual.Commands.ContainsKey("exit"));
        Assert.IsTrue(actual.Commands.ContainsKey("create rhombus"));
    }
}
