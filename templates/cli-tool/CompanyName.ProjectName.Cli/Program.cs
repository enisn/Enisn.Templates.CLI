﻿using CliFx;
using CompanyName.ProjectName.Cli;
using Microsoft.Extensions.DependencyInjection;
#if NugetUpdateCheck
using CompanyName.ProjectName.Cli.Services;
#endif

internal class Program
{
    private static async Task<int>  Main(string[] args) =>
        await new CliApplicationBuilder()
                .SetExecutableName("ProjectName")
                .SetDescription("CLI tool for ProjectName")
                .SetTitle("ProjectName CLI")
                .BuildServices()
                .Build()
                .RunAsync();
}

public static class Startup
{
    public static CliApplicationBuilder BuildServices(this CliApplicationBuilder builder)
    {
        var services = new ServiceCollection();

        // 👇 This uses reflection and it may cause some starting delay. 
        // builder.AddCommandsFromThisAssembly();

        // Registering manually is suggested for better performance.
        builder.AddCommand<HelloCommand>(); 

        services.AutoRegister();

        var serviceProvider = services.BuildServiceProvider();

#if NugetUpdateCheck
        serviceProvider.GetRequiredService<UpdateChecker>().CheckAsync().Wait();
#endif

        return builder.UseTypeActivator(serviceProvider);
    }
}