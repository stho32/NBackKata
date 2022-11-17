using nback.Domain;
using nback.Interactors.RunTest;
using nback.Interactors.Tests.Mocks;
using NUnit.Framework;

namespace nback.Interactors.Tests;

[TestFixture]
public class RunTestInteractorTests
{
    private void Setup(out RunTestInteractor interactor, out TimerMock timer)
    {
        var configuration = new ConfigurationForTheTest("Stefan", 1, 100, 1);
        var streamOfStimuli = new StreamOfStimuli("A");
        
        timer = new TimerMock();
        interactor = new RunTestInteractor(configuration, streamOfStimuli, timer);
    }
    
    [Test]
    public void After_Init_we_are_ready_to_start_but_not_started_yet()
    {
        Setup(out var interactor, out var timer);
        
        interactor.UiChangeNotificationEvent += delegate(RunTestDomainModel model)
        {
            Assert.AreEqual(string.Empty, model.Stimulus);
            Assert.AreEqual(false, model.DeclarePatternARepetitionIsLoggedIn);
            Assert.AreEqual(false, model.DeclarePatternIsNotARepetitonIsLoggedIn);
            Assert.AreEqual(true, model.YouHaveReachedTheEnd);
        };
        
        interactor.Init();
    }
    
    [Test]
    public void After_start_the_timer_is_running_and_we_have_the_first_stimulus_available()
    {
        Setup(out var interactor, out var timer);
        
        interactor.Init();
        
        interactor.UiChangeNotificationEvent += delegate(RunTestDomainModel model)
        {
            Assert.AreEqual("A", model.Stimulus);
            Assert.AreEqual(false, model.DeclarePatternARepetitionIsLoggedIn);
            Assert.AreEqual(false, model.DeclarePatternIsNotARepetitonIsLoggedIn);
            Assert.AreEqual(false, model.YouHaveReachedTheEnd);
        };

        interactor.Start();
        
        Assert.IsTrue(timer.IsRunning);
    }
    
    [Test]
    public void After_the_first_tick_the_test_stops_again_since_we_are_out_of_stimuli()
    {
        Setup(out var interactor, out var timer);
        
        interactor.Init();
        interactor.Start();
        
        interactor.UiChangeNotificationEvent += delegate(RunTestDomainModel model)
        {
            Assert.AreEqual(string.Empty, model.Stimulus);
            Assert.AreEqual(false, model.DeclarePatternARepetitionIsLoggedIn);
            Assert.AreEqual(false, model.DeclarePatternIsNotARepetitonIsLoggedIn);
            Assert.AreEqual(true, model.YouHaveReachedTheEnd);
        };
        
        timer.SimulateTick();

        Assert.IsFalse(timer.IsRunning);
    }
}
