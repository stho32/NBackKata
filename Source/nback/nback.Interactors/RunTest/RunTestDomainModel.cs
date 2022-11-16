namespace nback.Interactors;

public record RunTestDomainModel(
    bool YouHaveReachedTheEnd,
    string Stimulus,
    bool DeclarePatternARepetitionIsLoggedIn,
    bool DeclarePatternIsNotARepetitonIsLoggedIn,
    string Message);