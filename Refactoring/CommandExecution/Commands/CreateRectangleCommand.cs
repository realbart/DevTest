namespace Refactoring.CommandExecution.Commands;

using Refactoring.CommandExecution;
using Refactoring.Commands;
using Refactoring.SurfaceCalculation.Shapes;

public class CreateRectangleCommand : ICommand
{
    public string CommandText => "create rectangle";

    public string? Description => "create rectangle {height} {width} (create a new rectangle)";

    public void Invoke(CommandContext context, string[] args)
    {
        var circle = new RectangleSurfaceCalculator(
            Height: double.Parse(args[2]),
            Width: double.Parse(args[3])
            );
        context.AddShape(circle);
    }
}
