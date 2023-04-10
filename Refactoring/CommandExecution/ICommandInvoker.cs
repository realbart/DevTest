namespace Refactoring.Commands
{
    public interface ICommandInvoker
    {
        /// <summary>
        /// Executes the command.
        /// </summary>
        void Invoke(CommandContext context, string commandLine);
    }
}