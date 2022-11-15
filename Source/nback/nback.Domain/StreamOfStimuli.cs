namespace nback.Domain;

public class StreamOfStimuli
{
    private readonly string _characterSequence;
    private int _pointer = -1;

    public StreamOfStimuli(string characterSequence)
    {
        _characterSequence = characterSequence;
    }

    public Result<string> GetNextStimulus()
    {
        _pointer += 1;
        if (_pointer > _characterSequence.Length - 1)
            return new Result<string>(false, string.Empty, "You have reached the end.");
        
        return new Result<string>(true, _characterSequence[_pointer].ToString(), string.Empty);
    }
}