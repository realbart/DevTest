namespace Refactoring;

using System;

public class Circle
{
    public double Radius { get; set; }

    public double CalculateSurfaceArea()
    {
        return Math.Round(Math.PI * (Radius * Radius), 2);
    }
}