namespace Refactoring.SurfaceCalculation.Shapes;

using Refactoring.SurfaceCalculation;

/// <summary>
/// Calculator for rectangle  surface areas.
/// </summary>
/// <param name="Height">The height of the rectangle.</param>
/// <param name="Width">The width of the rectangle.</param>
internal record RectangleSurfaceCalculator(
    double Height,
    double Width
) : ISurface
{
    /// <inheritdoc/>
    public string Name => "Rectangle";

    /// <inheritdoc/>
    public double CalculateSurfaceArea() => Height * Width;
}