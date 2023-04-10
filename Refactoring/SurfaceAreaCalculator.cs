namespace Refactoring;

using Refactoring.SurfaceCalculation;
using System;
using System.Collections.Generic;
using System.Linq;

public class SurfaceAreaCalculator
{
    /// <summary>
    /// Holds a collection of items that can have surface areas.
    /// </summary>
    public List<ISurface> Shapes { get; set; } = new List<ISurface>();
    public List<double> SurfaceAreas { get; set; } = new List<double>();
    internal Logger Logger { get; private set; }

    public SurfaceAreaCalculator()
    {
        this.Logger = new Logger();
    }

    public void ShowCommands()
    {
        this.Logger.Log("commands:");
        this.Logger.Log("- create square {double} (create a new square)");
        this.Logger.Log("- create circle {double} (create a new circle)");
        this.Logger.Log("- create rectangle {height} {width} (create a new rectangle)");
        this.Logger.Log("- create triangle {height} {width} (create a new triangle)");
        this.Logger.Log("- print (print the calculated surface areas)");
        this.Logger.Log("- calculate (calulate the surface areas of the created shapes)");
        this.Logger.Log("- reset (reset)");
        this.Logger.Log("- exit (exit the loop)");
    }

    public void ReadString(string pCommand)
    {
        string[] arrCommands = pCommand.Split(' ');
        switch (arrCommands[0].ToLower())
        {
            case "create":
                if (arrCommands.Length > 1)
                {
                    switch (arrCommands[1].ToLower())
                    {
                        case "square":
                            var square = new Square(Side: double.Parse(arrCommands[2]));
                            Shapes.Add(square);
                            CalculateSurfaceAreas();
                            Console.WriteLine("{0} created!", square.GetType().Name);
                            break;
                        case "circle":
                            var circle = new Circle(Radius: double.Parse(arrCommands[2]));
                            Shapes.Add(circle);
                            CalculateSurfaceAreas();
                            Console.WriteLine("{0} created!", circle.GetType().Name);
                            break;
                        case "triangle":
                            var triangle = new Triangle(
                                Height: double.Parse(arrCommands[2]),
                                Base: double.Parse(arrCommands[3])
                            );
                            Shapes.Add(triangle);
                            CalculateSurfaceAreas();
                            Console.WriteLine("{0} created!", triangle.GetType().Name);
                            break;
                        case "rectangle":
                            var rectangle = new Rectangle(
                                Height: double.Parse(arrCommands[2]),
                                Width: double.Parse(arrCommands[3])
                            );
                            Shapes.Add(rectangle);
                            CalculateSurfaceAreas();
                            Console.WriteLine("{0} created!", rectangle.GetType().Name);
                            break;
                        default:
                            goto ShowCommands;
                    }
                }
                else
                {
                    ShowCommands();
                }
                this.ReadString(Console.ReadLine());
                break;
            case "calculate":
                this.CalculateSurfaceAreas();
                this.ReadString(Console.ReadLine());
                break;
            case "print":
                if (SurfaceAreas != null)
                {
                    for (int i = 0; i < SurfaceAreas.Count; i++)
                    {
                        Console.WriteLine("[{0}] {1} surface area is {2}", i, Shapes[i].GetType().Name, SurfaceAreas[i]);
                    }
                }
                else
                {
                    Console.WriteLine("There are no surface areas to print");
                }
                this.ReadString(Console.ReadLine());
                break;
            case "reset":
                this.SurfaceAreas.Clear();
                this.Shapes.Clear();
                Console.WriteLine("Reset state!!");
                this.ReadString(Console.ReadLine());
                break;
            case "exit":
                break;
            default:
            ShowCommands:
                this.Logger.Log("Unknown command!!!");
                this.Logger.Log("commands:");
                this.Logger.Log("- create square {double} (create a new square)");
                this.Logger.Log("- create circle {double} (create a new circle)");
                this.Logger.Log("- create rectangle {height} {width} (create a new rectangle)");
                this.Logger.Log("- create triangle {height} {width} (create a new triangle)");
                this.Logger.Log("- print (print the calculated surface areas)");
                this.Logger.Log("- calculate (calulate the surface areas of the created shapes)");
                this.Logger.Log("- reset (reset)");
                this.Logger.Log("- exit (exit the loop)");
                this.ReadString(Console.ReadLine());
                break;
        }
    }

    /// <summary>
    /// Calculates the shape surface areas and caches them for future use.
    /// </summary>
    /// <remarks>
    /// An explicit calculation step allows for the caching of results that are slow to calculate.
    /// If we can be certain such items will never be added to the application, 
    /// it's better to calculate the surface area on the fly.
    /// </remarks>
    public void CalculateSurfaceAreas()
    {
        try
        {
            foreach (var obj in Shapes.Skip(SurfaceAreas.Count))
            {
                SurfaceAreas.Add(obj.CalculateSurfaceArea());
            }
        }
        catch (Exception ex)
        {
            Logger.Log(ex.ToString());
            Shapes.Clear();
            SurfaceAreas.Clear();
        }
    }
}
