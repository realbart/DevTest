namespace Refactoring;

public class Rectangle
{
    public double Height { get; set; }

    public double Width { get; set; }

    public double CalculateSurfaceArea()
    {
        return Height * Width;
    }
}