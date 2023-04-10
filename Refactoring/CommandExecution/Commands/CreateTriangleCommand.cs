namespace Refactoring.CommandExecution.Commands;

using Refactoring.CommandExecution;
using Refactoring.Commands;
using Refactoring.SurfaceCalculation.Shapes;

public class CreateTriangleCommand : ICommand
{
    public string CommandText => "create triangle";

    public string? Description => "create triangle {height} {width} (create a new triangle)";

    public void Invoke(CommandContext context, string[] args)
    {
        var circle = new TriangleSurfaceCalculator(
            Height: double.Parse(args[2]),
            Base: double.Parse(args[3])
            );
        context.AddShape(circle);
    }
}