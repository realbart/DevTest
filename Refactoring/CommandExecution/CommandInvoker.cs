namespace Refactoring.Commands
{
    using Refactoring.CommandExecution;

    public class CommandInvoker : ICommandInvoker
    {
        /// <inheritdoc/>
        public void Invoke(CommandContext context, string commandLine)
        {
            var words = commandLine.Split(' ');
            if (words.Length>1 && context.Commands.TryGetValue($"{words[0]} {words[1]}", out var multiWordCommand))
            {
                multiWordCommand.Invoke(context, words);
            }
            else if (context.Commands.TryGetValue(words[0], out var command))
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
