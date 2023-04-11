namespace Refactoring.CommandExecution.Commands;

using Refactoring.CommandExecution;
using Refactoring.Commands;

public class CreateSquareCommand : ICommand
{
    public string CommandText => "create square";

    public string Description => "create square {double} (create a new square)";

    public void Invoke(CommandContext context, string[] args)
    {
        var side = double.Parse(args[2]);
        Invoke(context, side);
    }

    /// <summary>
    /// Does the actual invocation after parsing the parameters.
    /// </summary>
    /// <param name="context">The command context containing all state.</param>
    /// <param name="side">The length of one side of the square</param>
    private static void Invoke(CommandContext context, double side)
    {
        var surfaceArea = side * side;
        context.AddShape("Square", surfaceArea);
    }
}
