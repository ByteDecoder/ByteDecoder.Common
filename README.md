# ByteDecoder.Common

![.NET Core](https://github.com/ByteDecoder/ByteDecoder.Common/workflows/.NET%20Core/badge.svg)
[![Maintainability](https://api.codeclimate.com/v1/badges/024aeeba0e933733b9dd/maintainability)](https://codeclimate.com/github/ByteDecoder/ByteDecoder.Common/maintainability)
[![Test Coverage](https://api.codeclimate.com/v1/badges/024aeeba0e933733b9dd/test_coverage)](https://codeclimate.com/github/ByteDecoder/ByteDecoder.Common/test_coverage)

Common utility classes, guard clauses, and more.

Targeted to .Net Standard 2.0

## Installation

Install the [ByteDecoder.Common NuGet Package](https://www.nuget.org/packages/ByteDecoder.Common).

### Package Manager Console

```porwershell
Install-Package ByteDecoder.Common
```

### .NET Core CLI

```bash
dotnet add package ByteDecoder.Common
```

## Examples and usage

### Guard Clauses

They are a piece of code in charge of protecting params at the top of methods against undesirable values.

Supported *Guard Clauses*:

- IfArgumentIsNull
- IfArgumentIsNullOrEmpty
- IfArgumentOutOfRange

Usage examples:

```csharp
using ByteDecoder.Common.GuardClauses;

// Null Argument Guard check
public void MethodOne(IEnumerable<string> collection)
{
  Guard.Break.IfArgumentIsNull(collection, nameof(collection));
  
  // More logic code if the param is suitable after the guard evaluates the condition.
}

// String is NUll or Empty Guard check
public void MethodTwo(string word)
{
  Guard.Break.IfArgumentIsNull(word, nameof(word));
  
  // More logic code if the param is suitable after the guard evaluates the condition.
}

// Calling the method and passing a null value in the param
MethodOne((IEnumerable<string>) null);  // This will throw an ArgumentNullException
MethodTwo(string.Empty);  // This will throw an ArgumentNullException
```

## Contributing

Bug reports and pull requests are welcome on GitHub at <https://github.com/ByteDecoder/ByteDecoder.Common>.

Copyright (c) 2020 [Rodrigo Reyes](https://twitter.com/bytedecoder) released under the MIT license
