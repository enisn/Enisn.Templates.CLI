using CliFx;
using CliFx.Attributes;
using CliFx.Infrastructure;

namespace CompanyName.ProjectName.Cli;

[RegisterTransient(typeof(HelloCommand))]
[Command("hello")]
public class HelloCommand : ICommand
{
    public async ValueTask ExecuteAsync(IConsole console)
    {
        await console.Output.WriteAsync("Hello, world!");
    }
}
