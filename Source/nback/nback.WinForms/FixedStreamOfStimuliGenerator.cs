using nback.Domain;

namespace nback.WinForms;

internal class FixedStreamOfStimuliGenerator : IStreamOfStimuliGenerator
{
    private readonly string _stream;

    public FixedStreamOfStimuliGenerator(string stream)
    {
        _stream = stream;
    }

    public StreamOfStimuli Generate(int numberOfStimuli)
    {
        if (numberOfStimuli < _stream.Length)
            return new StreamOfStimuli(_stream.Substring(0, numberOfStimuli - 1));

        return new StreamOfStimuli(_stream);
    }

    public override string ToString()
    {
        return "Fixed Stream: " + _stream;
    }
}