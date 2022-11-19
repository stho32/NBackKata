using nback.Domain.Tests;

namespace nback.Domain;

public static class StreamOfStimuliExtensionMethods
{
    public static StreamOfAnswers ToExpectedAnswers(this StreamOfStimuli streamOfStimuli, int n)
    {
        var listOfCharacters = streamOfStimuli.AllStimuli;
        var result = new StreamOfAnswers();

        for (var i = 0; i < listOfCharacters.Length; i++)
        {
            var characterNCharactersBefore = GetCharacterFromPosition(listOfCharacters, i - n);

            result.AddAnswer(characterNCharactersBefore == listOfCharacters[i].ToString());
        }

        return result;
    }

    private static string GetCharacterFromPosition(string listOfCharacters, int index)
    {
        if (index < 0)
            return string.Empty;

        return listOfCharacters[index].ToString();
    }
}