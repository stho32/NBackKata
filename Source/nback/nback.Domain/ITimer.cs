namespace nback.Domain;

public interface ITimer
{
    void Configure(int timeIntervalInMilliseconds, Action callback);
    void Start();
    void Stop();
}