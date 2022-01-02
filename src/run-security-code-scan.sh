#!/bin/sh
set -e

dotnet tool update security-scan
dotnet security-scan ./ByteDecoder.Common.sln