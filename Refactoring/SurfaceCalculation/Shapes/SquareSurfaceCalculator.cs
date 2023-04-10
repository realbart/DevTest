namespace Refactoring.SurfaceCalculation.Shapes;

using Refactoring.SurfaceCalculation;

/// <summary>
/// Calculator for square surface areas.
/// </summary>
/// <param name="Side">The length of one side of the square</param>
internal record SquareSurfaceCalculator(
    double Side
) : ISurface
{
    /// <inheritdoc/>
    public string Name => "Square";


    /// <inheritdoc/>
    public double CalculateSurfaceArea() => Side * Side;
}