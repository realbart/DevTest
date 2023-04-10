namespace Refactoring;

using Refactoring.Services.SurfaceCalculation;
using System;

/// <summary>
/// Calculator for circle  surface areas.
/// </summary>
/// <param name="Radius">The distance for the center to the perimeter</param>
public record Circle
(
    double Radius
) :ISurface
{
    /// <summary>
    /// Calculates the surface area of a circle, rounded to two decimals using Bankers Rounding.
    /// </summary>
    public double CalculateSurfaceArea() => Math.Round(Math.PI * (Radius * Radius), 2);
}