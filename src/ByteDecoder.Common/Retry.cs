namespace ByteDecoder.Common;

/// <summary>
/// Lambda-based retry wrapper logic.
///
/// Usage:
/// Retry.Do(() => SomeFunctionThatCanFail(), TimeSpan.FromSeconds(1));
/// Retry.Do(SomeFunctionThatCanFail, TimeSpan.FromSeconds(1));
/// int result = Retry.Do(SomeFunctionWhichReturnsInt, TimeSpan.FromSeconds(1), 4);
/// await DoAsync(DoSomethingAsync, TimeSpan.FromSeconds(2), tryCount: 10);.
/// </summary>
public static class Retry
{
    /// <summary>
    ///
    /// </summary>
    /// <param name="action"></param>
    /// <param name="retryInterval"></param>
    /// <param name="maxAttemptCount"></param>
    public static void Do(Action action, TimeSpan retryInterval, int maxAttemptCount = 3)
    {
        Do<object?>(
            () =>
        {
            action();
            return null;
        }, retryInterval, maxAttemptCount);
    }

    /// <summary>
    ///
    /// </summary>
    /// <param name="action"></param>
    /// <param name="retryInterval"></param>
    /// <param name="maxAttemptCount"></param>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    public static T Do<T>(Func<T> action, TimeSpan retryInterval, int maxAttemptCount = 3)
    {
        if (maxAttemptCount <= 0)
            throw new ArgumentOutOfRangeException(nameof(maxAttemptCount));

        var exceptions = new List<Exception>();

        for (int attempted = 0; attempted < maxAttemptCount; attempted++)
        {
            try
            {
                if (attempted > 0)
                {
                    Thread.Sleep(retryInterval);
                }

                return action();
            }
            catch (Exception ex)
            {
                exceptions.Add(ex);
            }
        }

        throw new AggregateException(exceptions);
    }

    /// <summary>
    /// Retry async version.
    ///
    /// Usage:
    /// await DoAsync(DoSomethingAsync, TimeSpan.FromSeconds(2), tryCount: 10);.
    /// </summary>
    /// <param name="action"></param>
    /// <param name="sleepPeriod"></param>
    /// <param name="tryCount"></param>
    /// <returns><placeholder>A <see cref="Task"/> representing the asynchronous operation.</placeholder></returns>
    public static async Task DoAsync(Func<Task> action, TimeSpan sleepPeriod, int tryCount = 3)
    {
        if (tryCount <= 0)
            throw new ArgumentOutOfRangeException(nameof(tryCount));

        while (true)
        {
            try
            {
                await action().ConfigureAwait(false);
                return;
            }
            catch
            {
                if (--tryCount == 0)
                    throw;
                await Task.Delay(sleepPeriod).ConfigureAwait(false);
            }
        }
    }
}
