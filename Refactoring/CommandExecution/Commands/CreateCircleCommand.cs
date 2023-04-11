namespace Refactoring.CommandExecution.Commands;

using Refactoring.CommandExecution;
using Refactoring.Commands;

public class CreateCircleCommand : ICommand
{
    public string CommandText => "create circle";

    public string Description => "create circle {double} (create a new circle)";

    public void Invoke(CommandContext context, string[] args)
    {
        var radius = double.Parse(args[2]);
        Invoke(context, radius);
    }

    /// <summary>
    /// Does the actual invocation after parsing the parameters.
    /// </summary>
    /// <param name="context">The command context containing all state.</param>
    /// <param name="radius">The distance for the center to the perimeter.</param>
    private static void Invoke(CommandContext context, double radius)
    {
        var surfaceArea = Math.Round(Math.PI * (radius * radius), 2);
        context.AddShape("Circle", surfaceArea);
    }
}