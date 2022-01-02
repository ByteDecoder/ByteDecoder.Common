namespace ByteDecoder.Common.GuardClauses;

/// <summary>
/// Indicates to Code Analysis that a method validates a particular parameter.
/// https://docs.microsoft.com/en-us/dotnet/api/microsoft.validatednotnullattribute?view=visualstudiosdk-2019.
/// </summary>
[AttributeUsage(AttributeTargets.Parameter, AllowMultiple = false, Inherited = false)]
public sealed class ValidatedNotNullAttribute : Attribute { }
