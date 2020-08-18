#!/bin/sh
set -e

dotnet tool update -g dotnet-format
dotnet format --check --verbosity diagnostic

