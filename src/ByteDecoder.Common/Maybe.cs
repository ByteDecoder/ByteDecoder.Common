using System.Collections;

namespace ByteDecoder.Common;

/// <summary>
/// Alternative to Tester/Doer and TryRead idioms to handle outputs.
/// Internally holds 0 or 1 element.
/// </summary>
/// <typeparam name="T"></typeparam>
public class Maybe<T> : IEnumerable<T>
{
    private readonly IEnumerable<T> _values;

    /// <summary>
    ///
    /// </summary>
    public Maybe()
    {
        _values = new T[0];
    }

    /// <summary>
    ///
    /// </summary>
    /// <param name="value"></param>
    public Maybe(T value)
    {
        _values = new[] { value };
    }

    /// <summary>
    ///
    /// </summary>
    /// <returns></returns>
    public IEnumerator<T> GetEnumerator() => _values.GetEnumerator();

    /// <summary>
    ///
    /// </summary>
    /// <returns></returns>
    IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();
}
