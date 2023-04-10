namespace Refactoring.UnitTest.Refactroring;

using Microsoft.Extensions.DependencyInjection;
using Refactoring.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

[TestClass]
public class StartupTests
{
    [TestMethod]
    public void ConfigureServices_BuildsAValidServiceCollectionContainingCommandLoop()
    {
        var actual = Startup.ConfigureServices();

        var services = actual.BuildServiceProvider();
        Assert.AreEqual(typeof(CommandLoop), services.GetRequiredService<ICommandLoop>().GetType());
    }
}
