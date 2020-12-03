@ECHO OFF

cls

echo Legion awaits

dotnet tool update -g dotnet-format
dotnet format --check --verbosity diagnostic