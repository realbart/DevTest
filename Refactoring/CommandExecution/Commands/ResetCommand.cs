namespace Refactoring.CommandExecution.Commands;

using Refactoring.CommandExecution;
using Refactoring.Commands;

public class ResetCommand : ICommand
{
    public string CommandText => "reset";

    public string? Description => "reset (reset)";

    public void Invoke(CommandContext context, string[] args)
    {
        context.Shapes.Clear();
        context.WriteLine("Reset state!!");
    }
}
