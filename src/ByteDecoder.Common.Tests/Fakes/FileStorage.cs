using System;
using System.IO;

namespace ByteDecoder.Common.Tests.Fakes;

/// <summary>
/// Example of usage:
/// var message = fileStorage.Read(49).DefaultIfEmpty("").Single();
/// This fake is designed under CQS principle (Command Query Separation Principle),
/// Postel's Law, Fail Fast concept and Maybe idiom.
/// </summary>
internal class FileStorage
{
    public FileStorage(string workingDirectory)
    {
        if (workingDirectory is null)
            throw new ArgumentNullException(nameof(workingDirectory));
        if (!Directory.Exists(workingDirectory))
            throw new ArgumentException("BOo", nameof(workingDirectory));

        WorkingDirectory = workingDirectory;
    }

    public string WorkingDirectory { get; }

    public void Save(int id, string message)
    {
        var path = this.GetFileName(id);
        File.WriteAllText(path, message);
    }

    public Maybe<string> Read(int id)
    {
        var path = this.GetFileName(id);
        if (!File.Exists(path))
            return new Maybe<string>();

        var message = File.ReadAllText(path);
        return new Maybe<string>(message);
    }

    public string GetFileName(int id) =>
        Path.Combine(this.WorkingDirectory, id + ".txt");
}
