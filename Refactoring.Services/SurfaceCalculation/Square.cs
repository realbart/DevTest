namespace Refactoring;

using Refactoring.Services.SurfaceCalculation;

/// <summary>
/// Calculator for square surface areas.
/// </summary>
/// <param name="Side">The length of one side of the square</param>
public record Square(
    double Side
): ISurface
{
    /// <inheritdoc/>
    public double CalculateSurfaceArea() => Side * Side;
}