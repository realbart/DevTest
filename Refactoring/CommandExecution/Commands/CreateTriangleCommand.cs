﻿namespace Refactoring.CommandExecution.Commands;

using Refactoring.CommandExecution;
using Refactoring.Commands;

public class CreateTriangleCommand : ICommand
{
    public string CommandText => "create triangle";

    public string Description => "create triangle {height} {width} (create a new triangle)";

    public void Invoke(CommandContext context, string[] args)
    {
        var height = double.Parse(args[2]);
        var baseLength = double.Parse(args[3]);
        Invoke(context, height, baseLength);
    }

    /// <summary>
    /// Does the actual invocation after parsing the parameters.
    /// </summary>
    /// <param name="context">The command context containing all state.</param>
    /// <param name="height">The distance from the base to the highest point.</param>
    /// <param name="baseLength">The side that is perpendicular to the height of a triangle.</param>
    /// <remarks>
    /// Strictly speaking, the width of a shape is traditionally interpreted to mean the width
    /// of the bounding box, yielding different results for obtuse-angled triangles.
    /// </remarks>
    private static void Invoke(CommandContext context, double height, double baseLength)
    {
        var surfaceArea = .5 * height * baseLength;
        context.AddShape("Triangle", surfaceArea);
    }
}