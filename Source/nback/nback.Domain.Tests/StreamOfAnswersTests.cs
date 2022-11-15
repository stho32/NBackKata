using NUnit.Framework;

namespace nback.Domain.Tests;

[TestFixture]
public class StreamOfAnswersTests
{
    [Test]
    public void A_stream_of_answers_is_a_list_of_boolean_values()
    {
        var streamOfAnswers = new StreamOfAnswers(new[] { true, true, false });
        Assert.That(streamOfAnswers.ToBoolArray(), Is.EqualTo(new[] { true, true, false }));
    }
    
    [Test]
    public void The_values_can_be_given_step_by_step_one_at_a_time()
    {
        var streamOfAnswers = new StreamOfAnswers();

        streamOfAnswers.AddAnswer(true);
        streamOfAnswers.AddAnswer(true);
        streamOfAnswers.AddAnswer(false);
        
        Assert.That(streamOfAnswers.ToBoolArray(), Is.EqualTo(new[] { true, true, false }));
    }

    [Test]
    public void It_can_be_tested_how_two_streams_of_answers_match()
    {
        var expectedAnswers = new StreamOfAnswers(new[] { true, false, true, false });
        var subjectAnswers = new StreamOfAnswers(new[] { false, true, true, false });

        var matchingAnswers = expectedAnswers.CompareTo(subjectAnswers);
        
        Assert.AreEqual(new[] {false, false, true, true}, matchingAnswers);
    }

    [Test]
    public void When_the_second_stream_contains_less_answers_than_the_first_one_false_is_suggested()
    {
        Assert.Fail();
    }

    [Test]
    public void
        When_the_first_stream_contains_less_answers_than_the_second_one_the_result_is_cut_to_the_length_of_the_first_one()
    {
        Assert.Fail();
    }
}
