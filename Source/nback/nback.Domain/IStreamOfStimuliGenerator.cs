namespace nback.Domain;

public interface IStreamOfStimuliGenerator
{
    StreamOfStimuli Generate(int numberOfStimuli);
}