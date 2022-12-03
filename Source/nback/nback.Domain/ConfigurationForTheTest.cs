namespace nback.Domain;

public record ConfigurationForTheTest(
    string NameOfSubject, 
    int N, 
    int StimulusDurationInMs, 
    int NumberOfStimuli);