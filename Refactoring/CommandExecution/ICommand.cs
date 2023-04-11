using Refactoring.Commands;

namespace Refactoring.CommandExecution;
public interface ICommand
{
    /// <summary>
    /// Returns the actual text to be entered and executed.
    /// </summary>
    string CommandText { get; }
    /// <summary>
    /// Returns a a string containing the command, the arguments and a description.
    /// </summary>
    string Description { get; }

    /// <summary>
    /// Executes the command.
    /// </summary>
    void Invoke(CommandContext context, string[] args);
}
