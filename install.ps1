param(
    [string]$version = "1.0.0"
)

pwsh ./pack.ps1 $version

dotnet new install .\nupkg\Enisn.Templates.CLI.$version.nupkg