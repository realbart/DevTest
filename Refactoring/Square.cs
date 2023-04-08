namespace Refactoring;

public class Square
{
    public double Side { get; set; }

    public double CalculateSurfaceArea()
    {
        return this.Side * this.Side;
    }
}