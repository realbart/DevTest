namespace Refactoring.CommandExecution.Commands;

using Refactoring.CommandExecution;
using Refactoring.Commands;
using Refactoring.SurfaceCalculation.Shapes;

public class CreateSquareCommand : ICommand
{
    public string CommandText => "create square";

    public string? Description => "create square {double} (create a new square)";

    public void Invoke(CommandContext context, string[] args)
    {
        var circle = new SquareSurfaceCalculator(
             Side: double.Parse(args[2])
            );
        context.AddShape(circle);
    }
}
