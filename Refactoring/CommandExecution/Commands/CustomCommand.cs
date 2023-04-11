namespace Refactoring.CommandExecution.Commands;

using Refactoring.CommandExecution;
using Refactoring.Commands;

public record CustomCommand(string CommandText, string Description, Action<CommandContext, string[]> action) : ICommand
{
    public void Invoke(CommandContext context, string[] args) => action(context, args);
}