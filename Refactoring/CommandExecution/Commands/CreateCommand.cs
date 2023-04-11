namespace Refactoring.CommandExecution.Commands;

using Refactoring.CommandExecution;
using Refactoring.Commands;

/// <summary>
/// A create command without a shape, or one with an unknown shape simply returns a list of commands 
/// (without the error message)
/// It is not listed.
/// </summary>
public class CreateCommand : ICommand
{
    public string CommandText => "create";

    public string? Description => default;

    public void Invoke(CommandContext context, string[] args) => context.ListCommands();
}