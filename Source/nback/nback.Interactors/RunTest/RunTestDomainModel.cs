namespace nback.Interactors.RunTest;

public record RunTestDomainModel(
    bool YouHaveReachedTheEnd,
    string Stimulus,
    bool DeclarePatternARepetitionIsLoggedIn,
    bool DeclarePatternIsNotARepetitonIsLoggedIn,
    string Message,
    int Position,
    int TotalAmountOfStimuli);