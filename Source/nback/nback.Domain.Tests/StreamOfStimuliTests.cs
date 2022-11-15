using NUnit.Framework;

namespace nback.Domain.Tests;

[TestFixture]
public class StreamOfStimuliTests
{
    [Test]
    public void A_stream_of_stimuli_is_initialized_and_then_plays_back_a_sequence_of_characters()
    {
        var streamOfStimuli = new StreamOfStimuli("A");

        var firstStimulus = streamOfStimuli.GetNextStimulus(); 
        Assert.AreEqual("A", firstStimulus.Value);
        Assert.AreEqual(true, firstStimulus.IsSuccess);
        Assert.AreEqual(string.Empty, firstStimulus.Message);

        var lastStimulus = streamOfStimuli.GetNextStimulus();
        
        Assert.AreEqual(string.Empty, lastStimulus.Value);
        Assert.AreEqual(false, lastStimulus.IsSuccess);
        Assert.AreEqual("You have reached the end.", lastStimulus.Message);
    } 
}