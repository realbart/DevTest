namespace Refactoring.CommandExecution.Commands;

using Refactoring.CommandExecution;
using Refactoring.Commands;
using Refactoring.SurfaceCalculation.Shapes;

public class CreateCircleCommand : ICommand
{
    public string CommandText => "create circle";

    public string? Description => "create circle {double} (create a new circle)";

    public void Invoke(CommandContext context, string[] args)
    {
        var circle = new CircleSurfaceCalculator(
            Radius: double.Parse(args[2])
            );
        context.AddShape(circle);
    } 
}