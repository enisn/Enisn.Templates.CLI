param(
    [string]$version = "1.0.0"
)

dotnet pack ./templates/Enisn.Templates.CLI.csproj -c Release --include-symbols --include-source -o ./nupkg -p:PackageVersion=$version