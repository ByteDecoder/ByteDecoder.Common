# Guard Clauses

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
