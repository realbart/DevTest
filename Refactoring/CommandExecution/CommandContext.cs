namespace Refactoring.Commands;

using Refactoring.CommandExecution;
using Refactoring.CommandExecution.Commands;
using Refactoring.SurfaceCalculation;

/// <summary>
/// Maintains state within the command loop
/// </summary>
public record CommandContext
    (IDictionary<string, ICommand> Commands)
{
    /// <summary>
    /// The place to write output to.
    /// </summary>
    public TextWriter Out { get; set; } = Console.Out;

    /// <summary>
    /// A list of items to calculate the surface areas for.
    /// </summary>
    public List<ISurface> Shapes { get; } = new List<ISurface>();

    /// <summary>
    /// A boolean indicating if command execution should continue
    /// </summary>
    public bool Continue { get; set; } = true;

    /// <summary>
    /// Creates a context with the correct commands in the correct order
    /// </summary>
    /// <returns></returns>
    public static CommandContext Create()
    {
        var commands = new ICommand[] {
                new CreateSquareCommand(),
                new CreateCircleCommand(),
                new CreateRectangleCommand(),
                new CreateTriangleCommand(),
                new CustomCommand("calculate", "calculate (calulate the surface areas of the created shapes)", (_,_) => { }),
                new PrintCommand(),
                new ResetCommand(),
                new CustomCommand("exit", "exit (exit the loop)", (context, _) => context.Continue = false)
            };
        return new CommandContext(commands.ToDictionary(c => c.CommandText, c => c));
    }
}
