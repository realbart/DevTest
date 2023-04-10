namespace Refactoring
{
    using Microsoft.Extensions.DependencyInjection;
    using Refactoring.Commands;

    internal class Startup
    {
        internal Startup(IServiceProvider serviceProvider) => Services = serviceProvider;

        internal Startup() : this(ConfigureServices().BuildServiceProvider())
        {
        }

        private IServiceProvider Services { get; }

        internal void Start() => Services.GetRequiredService<ICommandLoop>().Start();

        internal static IServiceCollection ConfigureServices()
        {
            var services = new ServiceCollection();
            services.AddScoped<ICommandLoop, CommandLoop>();
            services.AddScoped<ICommandInvoker, CommandInvoker>();
            services.AddScoped(_ => CommandContext.Create());
            services.AddScoped<IConsole, ConsoleAdapter>();
            return services;
        }
    }
}