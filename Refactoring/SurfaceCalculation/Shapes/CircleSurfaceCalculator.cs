namespace Refactoring.SurfaceCalculation.Shapes;

using Refactoring.SurfaceCalculation;

/// <summary>
/// Calculator for circle  surface areas.
/// </summary>
/// <param name="Radius">The distance for the center to the perimeter</param>
internal record CircleSurfaceCalculator
(
    double Radius
) : ISurface
{
    /// <inheritdoc/>
    public string Name => "Circle";

    /// <summary>
    /// Calculates the surface area of a circle, rounded to two decimals using Bankers Rounding.
    /// </summary>
    public double CalculateSurfaceArea() => Math.Round(Math.PI * (Radius * Radius), 2);
}