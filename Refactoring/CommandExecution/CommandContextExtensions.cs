namespace Refactoring.CommandExecution;

using Refactoring.Commands;
using Refactoring.SurfaceCalculation;

internal static class CommandContextExtensions
{
    /// <summary>
    /// Utility method that writes a line of text to the output textwriter.
    /// </summary>
    internal static void WriteLine(this CommandContext context, string text) => context.Out.WriteLine(text);

    /// <summary>
    /// Adds the shape to the context.
    /// Writes that the shape has been created to the output textwriter.
    /// </summary>
    public static void AddShape(this CommandContext context, ISurface shape)
    {
        context.Shapes.Add(shape);
        context.WriteLine($"{shape.Name} created!");
    }

    /// <summary>
    /// Writes a list of possible commands to the output textwriter.
    /// </summary>
    public static void ListCommands(this CommandContext context)
    {
        context.WriteLine("commands:");
        foreach (var command in context.Commands)
        {
            var description = command.Value.Description;
            if (description != null)
            {
                context.WriteLine($"- {description}");
            }
        }
    }
}