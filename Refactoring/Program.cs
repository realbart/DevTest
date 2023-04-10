namespace Refactoring;

using System;

internal static class Program
{
    internal static Startup Startup { get; set; } = new Startup();

    internal static void Main(params string[] args)
    {
        Console.WriteLine(" -------------------------------------------------------------------------- ");
        Console.WriteLine("| Greetings and salutations fellow developer :D                            |");
        Console.WriteLine("|                                                                          |");
        Console.WriteLine("| If you are reading this we probably want to know if you know your stuff. |");
        Console.WriteLine("|                                                                          |");
        Console.WriteLine("| How would you improve this code?                                         |");
        Console.WriteLine("| We challenge you to refactor this and show us how awesome you are ;)     |");
        Console.WriteLine("| We also really like trapezoids so could you also implement that for us?  |");
        Console.WriteLine("|                                                                          |");
        Console.WriteLine("|                                                               Good luck! |");
        Console.WriteLine(" --------------------------------------------------------------------------");
        Startup.Start();
        // I removed "Wait for keypress" here, as it didn't seem to be part of the main flow.
        // Other than that, the solution should behave exactly like it did, except for different stack traces
        // when exceptions are thrown.
        // This is the totally overengineered use-every-design-pattern-that-seems-applicable-version.
        // In real life, I'd leave an application that calculates surface areas alone: any change isn't worth the effort.
    }
}