namespace Refactoring.Commands;

using Refactoring.CommandExecution;

public class CommandLoop : ICommandLoop
{
    private readonly IConsole console;
    private readonly ICommandInvoker commandExecutor;
    private readonly CommandContext context;

    public CommandLoop(IConsole console, ICommandInvoker commandExecutor, CommandContext context)
    {
        this.console = console;
        this.commandExecutor = commandExecutor;
        this.context = context;
    }

    /// <inheritdoc/>
    public void Start()
    {
        context.ListCommands();
        while (context.Continue)
        {
            var commandLine = console.ReadLine();
            commandExecutor.Invoke(context, commandLine);
        }
    }
}