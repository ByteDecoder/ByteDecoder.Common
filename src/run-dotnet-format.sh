#!/bin/sh
set -e

dotnet tool update dotnet-format
dotnet format --verbosity diagnostic

