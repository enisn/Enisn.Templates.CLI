# CliTemplate
 Pre-configured dotnet tool CLI template.

 Features implemented:
     - [CliFx](https://github.com/Tyrrrz/CliFx)

## Installation
You can install it as dotnet new template:
```bash
dotnet new --install Enisn.Templates.Cli
```

## Usage
You can create a new project from terminal:

```bash
dotnet new cli -n MyCli
```

If you wish to use Nuget Update checker you can pass `-NugetUpdateCheck` or `-N` option to the command:

```bash
dotnet new cli -n MyCli -N
```

## Showcase
- [AbpDevTools](https://github.com/enisn/AbpDevTools) is a project that uses this template. You can check it out for a real-world example.

