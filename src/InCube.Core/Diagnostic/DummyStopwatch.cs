using System;

namespace InCube.Core.Diagnostic;

/// <summary>
/// Stopwatch that does nothing.
/// </summary>
public sealed class DummyStopwatch : IStopwatch
{
    private const int ZeroTicks = 0;

    /// <summary>
    /// The singleton <see cref="DummyStopwatch" />.
    /// </summary>
    public static readonly DummyStopwatch Instance = new();

    private static readonly TimeSpan EmptyTimeSpan = new(ZeroTicks);

    private DummyStopwatch()
    {
    }

    /// <inheritdoc />
    public bool IsRunning => false;

    /// <inheritdoc />
    public TimeSpan Elapsed => EmptyTimeSpan;

    /// <inheritdoc />
    public long ElapsedMilliseconds => ZeroTicks;

    /// <inheritdoc />
    public long ElapsedTicks => ZeroTicks;

    /// <inheritdoc />
    public void Start()
    {
    }

    /// <inheritdoc />
    public void Stop()
    {
    }

    /// <inheritdoc />
    public void Reset()
    {
    }

    /// <inheritdoc />
    public void Restart()
    {
    }

    /// <summary>
    /// Gets a reference to the single instance of the <see cref="DummyStopwatch" />.
    /// </summary>
    /// <returns>The <see cref="DummyStopwatch" />.</returns>
    public static DummyStopwatch StartNew() => Instance;

    /// <summary>
    /// Gets zero.
    /// </summary>
    /// <returns>Zero.</returns>
    public static long GetTimestamp() => ZeroTicks;
}