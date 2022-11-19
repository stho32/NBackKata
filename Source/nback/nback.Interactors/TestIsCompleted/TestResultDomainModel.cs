using nback.Domain;
using nback.Domain.Tests;

namespace nback.Interactors.TestIsCompleted;

public record TestResultDomainModel(
    ConfigurationForTheTest Configuration,
    StreamOfStimuli StreamOfStimuli,
    StreamOfAnswers StreamOfAnswers,
    decimal? PercentageOfCorrectAnswers
);