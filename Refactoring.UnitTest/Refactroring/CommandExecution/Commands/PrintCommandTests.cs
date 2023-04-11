namespace Refactoring.UnitTest.Refactroring.CommandExecution.Commands;

using Refactoring.CommandExecution;
using Refactoring.CommandExecution.Commands;
using Refactoring.Commands;
using Refactoring.Models;

[TestClass]
public class PrintCommandTests
{
    [TestMethod]
    public void Invoke_PrintsShapesToOutStream()
    {
        var writer = new StringWriter();
        var commands = new Dictionary<string, ICommand>();
        var shape = new Shape("Apple", 1337);
        var context = new CommandContext(commands) { Out = writer };
        context.Shapes.Add(shape);
        var sut = new PrintCommand();

        sut.Invoke(context, default!);

        var actual = writer.ToString();
        Assert.IsTrue(actual.Contains("Apple surface area is 1337"));
    }
}