namespace nback.Domain;

public class StreamOfStimuli
{
    private readonly string _characterSequence;
    private int _pointer = -1;

    public StreamOfStimuli(string characterSequence)
    {
        _characterSequence = characterSequence;
    }

    public int Position => _pointer +1;
    public int TotalAmount => _characterSequence.Length;

    public Result<string> GetNextStimulus()
    {
        _pointer += 1;
        if (_pointer > _characterSequence.Length - 1)
            return new Result<string>(false, string.Empty, "You have reached the end.");
        
        return new Result<string>(true, _characterSequence[_pointer].ToString(), string.Empty);
    }

    public string AllStimuli => _characterSequence;

    public override string ToString()
    {
        if (_pointer > -1)
            return _characterSequence.Substring(0, _pointer);
        return _characterSequence;
    }
}