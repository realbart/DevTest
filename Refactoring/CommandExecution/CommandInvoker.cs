namespace Refactoring.Commands
{
    using Refactoring.CommandExecution;

    public class CommandInvoker : ICommandInvoker
    {
        /// <inheritdoc/>
        public void Invoke(CommandContext context, string commandLine)
        {
            var words = commandLine.Split(' ');
            var commandText = string.Join(' ', words.Take(2));
            if (context.Commands.TryGetValue(commandText, out var command))
            {
                command.Invoke(context, words);
            }
            else
            {
                context.WriteLine("Unknown Command!!!");
                context.ListCommands();
            }
        }
    }
}
