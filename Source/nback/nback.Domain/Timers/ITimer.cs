namespace nback.Domain.Timers;

public interface ITimer
{
    void Configure(int timeIntervalInMilliseconds, Action callback);
    void Start();
    void Stop();
}