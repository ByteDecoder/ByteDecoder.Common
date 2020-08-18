# Project Development guidleines

## Generating the Library DocFX documentation

Execute in the commandline the next bash script

```bash
./release-docfx/sh
```

## Installing dotnet-format tool

```bash
dotnet tool update -g dotnet-format
dotnet format --dry-run --check
```

More about in <https://www.meziantou.net/enforce-dotnet-code-style-in-ci-with-dotnet-format.htm>
