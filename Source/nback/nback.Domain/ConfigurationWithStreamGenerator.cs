namespace nback.Domain;

public record ConfigurationWithStreamGenerator(
    ConfigurationForTheTest Configuration,
    IStreamOfStimuliGenerator StreamOfStimuliGenerator
);