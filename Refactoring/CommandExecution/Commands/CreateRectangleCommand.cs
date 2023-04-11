namespace Refactoring.CommandExecution.Commands;

using Refactoring.CommandExecution;
using Refactoring.Commands;

public class CreateRectangleCommand : ICommand
{
    public string CommandText => "create rectangle";

    public string? Description => "create rectangle {height} {width} (create a new rectangle)";

    public void Invoke(CommandContext context, string[] args)
    {
        var height = double.Parse(args[2]);
        var width = double.Parse(args[3]);
        Invoke(context, height, width);
    }

    /// <summary>
    /// Does the actual invocation after parsing the parameters.
    /// </summary>
    /// <param name="context">The command context containing all state.</param>
    /// <param name="height">The height of the rectangle.</param>
    /// <param name="width">The width of the rectangle.</param>
    private static void Invoke(CommandContext context, double height, double width)
    {
        var surfaceArea = height * width;
        context.AddShape("Rectangle", surfaceArea);
    }
}
