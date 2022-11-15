namespace nback.Domain.Tests;

public class StreamOfAnswers
{
    private List<bool> _values;

    public StreamOfAnswers(bool[]? values = null)
    {
        if (values == null)
            values = Array.Empty<bool>();
        
        _values = new List<bool>(values);
    }

    public bool[] ToBoolArray()
    {
        return _values.ToArray();
    }

    public void AddAnswer(bool answer)
    {
        _values.Add(answer);
    }

    public bool[] CompareTo(StreamOfAnswers theOtherAnswers)
    {
        var matches = new List<bool>();
        var theOtherAnswersAsBools = theOtherAnswers.ToBoolArray();

        for (int i = 0; i < _values.Count; i++)
        {
            if (theOtherAnswersAsBools.Length >= i)
            {
                matches.Add(false);
                continue;
            } 
            
            matches.Add(_values[i] == theOtherAnswersAsBools[i]);
        }

        return matches.ToArray();
    }
}