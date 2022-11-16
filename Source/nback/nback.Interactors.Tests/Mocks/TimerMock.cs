using nback.Domain.Timers;

namespace nback.Interactors.Tests.Mocks;

public class TimerMock : ITimer
{
    private Action? _callback;
    public bool IsRunning { get; private set; }

    public TimerMock()
    {
        IsRunning = false;
    }
    
    public void Configure(int timeIntervalInMilliseconds, Action callback)
    {
        _callback = callback;
    }

    public void Start()
    {
        IsRunning = true;
    }

    public void Stop()
    {
        IsRunning = false;
    }

    public void SimulateTick()
    {
        if (IsRunning && _callback != null)
            _callback();
    }
}