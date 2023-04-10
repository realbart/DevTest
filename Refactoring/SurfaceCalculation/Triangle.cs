namespace Refactoring.SurfaceCalculation;

using Refactoring.SurfaceCalculation;

/// <summary>
/// Calculator for triangle surface areas.
/// </summary>
/// <param name="Height">The distance from the base to the highest point.</param>
/// <param name="Base">The side that is perpendicular to the height of a triangle.</param>
/// <remarks>
/// Strictly speaking, the width of a shape is traditionally interpreted to mean the width
/// of the bounding box, yielding different results for obtuse-angled triangles.
/// </remarks>
public record Triangle
(
    double Height,
    double Base
) : ISurface
{
    /// <inheritdoc/>
    public double CalculateSurfaceArea() => .5 * Height * Base;
}