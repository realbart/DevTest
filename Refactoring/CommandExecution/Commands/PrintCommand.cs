namespace Refactoring.CommandExecution.Commands;

using Refactoring.CommandExecution;
using Refactoring.Commands;
using Refactoring.SurfaceCalculation;

public class PrintCommand : ICommand
{
    public string CommandText => "print";
    public string Description => "print (print the calculated surface areas)";
    public void Invoke(CommandContext context, string[] args)
    {
        if (context.Shapes.Count == 0)
        {
            context.WriteLine("There are no surface areas to print");
            return;
        }
        foreach ((ISurface shape, int index) in context.Shapes.Select((s, i) => (s, i)))
        {
            context.WriteLine($"[{index}] {shape.Name} surface area is {shape.CalculateSurfaceArea()}");
        }
    }
}