namespace Refactoring.SurfaceCalculation;

/// <summary>
/// Privides a common interface for items a surface area can be calculated for.
/// </summary>
/// <remarks>
/// These classes do not necessarily represent 2d shapes; surfaces can also be calculated for 3d objects or possibly for other items.
/// Classes implementing <see cref="ISurface"/> may only have a subset of the information needed to define a shape.
/// For example, a <see cref="Triangle"/> is not fully defined by its height and base, but these numbers do provide enough 
/// information to calculate the surface area.
/// </remarks>
public interface ISurface
{
    /// <summary>
    /// Calculates the surface area for the object.
    /// </summary>
    public double CalculateSurfaceArea();
}
