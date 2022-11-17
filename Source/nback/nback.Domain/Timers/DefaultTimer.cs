using System.Timers;
using Timer = System.Timers.Timer;

namespace nback.Domain.Timers;

public class DefaultTimer : ITimer
{
    private int _timeIntervalInMilliseconds;
    private Action _callback;
    private Timer _systemTimer;

    public void Configure(int timeIntervalInMilliseconds, Action callback)
    {
        _timeIntervalInMilliseconds = timeIntervalInMilliseconds;
        _callback = callback;
        _systemTimer = new Timer(_timeIntervalInMilliseconds);
        _systemTimer.Elapsed += OnTimerFiring;
    }

    private void OnTimerFiring(object? sender, ElapsedEventArgs e)
    {
        if (_callback != null)
            _callback();
    }

    public void Start()
    {
        _systemTimer.Enabled = true;
    }

    public void Stop()
    {
        _systemTimer.Enabled = false;
    }
}