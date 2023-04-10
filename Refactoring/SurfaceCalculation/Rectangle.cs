namespace Refactoring.SurfaceCalculation;

using Refactoring.SurfaceCalculation;

/// <summary>
/// Calculator for rectangle  surface areas.
/// </summary>
/// <param name="Height">The height of the rectangle.</param>
/// <param name="Width">The width of the rectangle.</param>
public record Rectangle(
    double Height,
    double Width
) : ISurface
{
    /// <inheritdoc/>
    public double CalculateSurfaceArea() => Height * Width;
}