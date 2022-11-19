using nback.Domain;
using nback.Domain.Tests;

namespace nback.Interactors.TestIsCompleted;

public static class TestResultCalculator {
    public static TestResultDomainModel GetTestResult(
        ConfigurationForTheTest configurationForTheTest, 
        StreamOfStimuli streamOfStimuli, 
        StreamOfAnswers streamOfAnswers)
    {
        var percentageCalculator = new PercentageCalculator();

        var expectedAnswers = streamOfStimuli.ToExpectedAnswers(configurationForTheTest.N);
        var judgedAnswers = streamOfAnswers.CompareTo(expectedAnswers);
        var percentageOfCorrectAnswers = percentageCalculator.PercentTrue(judgedAnswers);

        return new TestResultDomainModel(
            configurationForTheTest,
            streamOfStimuli,
            streamOfAnswers,
            percentageOfCorrectAnswers
        );
    }
}