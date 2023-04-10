namespace Refactoring.UnitTest.Refactroring;

using Microsoft.Extensions.DependencyInjection;
using Refactoring.Commands;

[TestClass]
public class ProgramTests
{
    [TestMethod]
    public void Main_UsesStartupToStartCommandLoop()
    {
        var commandLoopMock = new Mock<ICommandLoop>();
        var services = new ServiceCollection();
        services.AddSingleton(commandLoopMock.Object);
        Program.Startup = new Startup(services.BuildServiceProvider());

        Program.Main();

        commandLoopMock.Verify(loop=>loop.Start(),Times.Once);
    }
}
