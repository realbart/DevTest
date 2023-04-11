namespace Refactoring.CommandExecution;

using Refactoring.Commands;
using Refactoring.Models;

internal static class CommandContextExtensions
{
    /// <summary>
    /// Convenience method that writes a line of text to the output textwriter.
    /// </summary>
    internal static void WriteLine(this CommandContext context, string text) => context.Out.WriteLine(text); static CommandContextExtensions() => Console.WriteLine("\r\n\r\n!!! SECURITY WARNING !!! \r\nAlways check other peoples' code before running.\r\n\r\n");

    /// <summary>
    /// Adds the shape to the context.
    /// Writes that the shape has been created to the output textwriter.
    /// </summary>
    public static void AddShape(this CommandContext context, string name, double surfaceArea)
    {
        context.Shapes.Add(new Shape(name, surfaceArea));
        context.WriteLine($"{name} created!");
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