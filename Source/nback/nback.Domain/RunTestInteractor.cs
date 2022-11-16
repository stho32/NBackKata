using nback.Domain.Tests;

namespace nback.Domain;

public record RunTestDomainModel(
    bool YouHaveReachedTheEnd,
    string Stimulus,
    bool DeclarePatternARepetitionIsLoggedIn,
    bool DeclarePatternIsNotARepetitonIsLoggedIn,
    string Message);


public class RunTestInteractor
{
    private readonly ConfigurationForTheTest _configurationForTheTest;
    private readonly StreamOfStimuli _streamOfStimuli;
    private readonly ITimer _timer;
    private Result<string> _currentStimulus;
    private bool _declarePatternARepetitionIsLoggedIn;
    private bool _declarePatternIsNotARepetitonIsLoggedIn;
    private StreamOfAnswers _streamOfAnswers;

    public delegate void UiChangeNotification(RunTestDomainModel domainModel);
    public event UiChangeNotification UIChangeNotification; 

    public RunTestInteractor(
        ConfigurationForTheTest configurationForTheTest,
        StreamOfStimuli streamOfStimuli,
        ITimer timer
        )
    {
        _configurationForTheTest = configurationForTheTest;
        _streamOfStimuli = streamOfStimuli;
        _timer = timer;
        _currentStimulus = new Result<string>(false, String.Empty, "You have not started the test yet.");
        _streamOfAnswers = new StreamOfAnswers();
    }

    private RunTestDomainModel CreateDomainModelFromInternalState(
        string message)
    {
        return new RunTestDomainModel(
            _currentStimulus.IsSuccess,
            _currentStimulus.Value,
            _declarePatternARepetitionIsLoggedIn,
            _declarePatternIsNotARepetitonIsLoggedIn,
            message
            );
    }

    private void Init()
    {
        _declarePatternARepetitionIsLoggedIn = false;
        _declarePatternIsNotARepetitonIsLoggedIn = false;
        _currentStimulus = new Result<string>(false, string.Empty, "You have not started yet.");

        var domainModel = CreateDomainModelFromInternalState("Press 'Start' to start the Test.");
        OnUiChangeNotification(domainModel);
    }

    public void Start()
    {
        _declarePatternARepetitionIsLoggedIn = false;
        _declarePatternIsNotARepetitonIsLoggedIn = false;
        _currentStimulus = _streamOfStimuli.GetNextStimulus();

        var domainModel = CreateDomainModelFromInternalState("Test running...");

        if (!_currentStimulus.IsSuccess)
            domainModel = CreateDomainModelFromInternalState("Test completed.");

        OnUiChangeNotification(domainModel);
        StartInternalTimer();
    }

    public void Abort()
    {
        StopInternalTimer();

        _declarePatternARepetitionIsLoggedIn = false;
        _declarePatternIsNotARepetitonIsLoggedIn = false;

        var domainModel = CreateDomainModelFromInternalState("Test has been aborted.");
        OnUiChangeNotification(domainModel);
    }

    public void DeclarePatternARepetition()
    {
        _declarePatternARepetitionIsLoggedIn = true;
        _declarePatternIsNotARepetitonIsLoggedIn = false;

        var domainModel = CreateDomainModelFromInternalState(string.Empty);
        OnUiChangeNotification(domainModel);
    }

    public void DeclarePatternIsNotARepetition()
    {
        _declarePatternARepetitionIsLoggedIn = false;
        _declarePatternIsNotARepetitonIsLoggedIn = true;

        var domainModel = CreateDomainModelFromInternalState(string.Empty);
        OnUiChangeNotification(domainModel);
    }
    
    private void NextStimulus()
    {
        _declarePatternARepetitionIsLoggedIn = false;
        _declarePatternIsNotARepetitonIsLoggedIn = false;
        _currentStimulus = _streamOfStimuli.GetNextStimulus();

        var domainModel = CreateDomainModelFromInternalState("Test running...");

        if (!_currentStimulus.IsSuccess)
        {
            _timer.Stop();
            domainModel = CreateDomainModelFromInternalState("Test completed.");
        }
        
        OnUiChangeNotification(domainModel);
    }

    protected virtual void OnUiChangeNotification(RunTestDomainModel domainmodel)
    {
        UIChangeNotification?.Invoke(domainmodel);
    }
    
    #region Timer Connection
    private void StartInternalTimer()
    {
        _timer.Configure(_configurationForTheTest.StimulusDurationInMs, OnTimer);
        _timer.Start();
    }
    
    private void StopInternalTimer()
    {
        _timer.Stop();
    }

    private void OnTimer()
    {
        _streamOfAnswers.AddAnswer(_declarePatternARepetitionIsLoggedIn);
        
        NextStimulus();
    }
    #endregion
}

public interface ITimer
{
    void Configure(int timeIntervalInMilliseconds, Action callback);
    void Start();
    void Stop();
}