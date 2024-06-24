namespace Refactoring.UnitTest.Refactroring.CommandExecution.Commands;

using Refactoring.CommandExecution.Commands;
using Refactoring.Commands;

[TestClass]
public class CreateRhombusCommandTests
{
    [TestMethod]
    [DataRow(13, 34, 442)]
    [DataRow(0, 34, 0)]
    [DataRow(34, 0, 0)]
    public void Invoke_AddsRhombusWithCorrectSurfaceArea(double height, double baseLength, double expected)
    {
        var sut = new CreateRhombusCommand();
        var context = new CommandContext(default!);

        sut.Invoke(context, new[] { "create", "rhombus", height.ToString(), baseLength.ToString() });

        Assert.AreEqual(1, context.Shapes.Count);
        var actual = context.Shapes[0];
        Assert.AreEqual("Rhombus", actual.Name);
        Assert.AreEqual(expected, actual.SurfaceArea);
    }
}