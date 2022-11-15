using NUnit.Framework;

namespace nback.Domain.Tests;

[TestFixture]
public class PercentageOfCorrectAnswersCalculatorTests
{
    [Test]
    public void When_all_answers_are_correct_you_have_100_percent()
    {
        var calculator = new PercentageCalculator();
        var percentage = calculator.PercentTrue(new[] {true, true, true});
        Assert.AreEqual(100m, percentage);
    }
    
    [Test]
    public void When_no_values_are_given_null_is_returned()
    {
        var calculator = new PercentageCalculator();
        var percentage = calculator.PercentTrue(Array.Empty<bool>());
        Assert.IsNull(percentage);
    }
    
    [Test]
    public void When_only_a_part_of_the_values_are_true_the_percentage_of_true_values_is_returned()
    {
        var calculator = new PercentageCalculator();
        var percentage = calculator.PercentTrue(new[] {true, false, false});
        var difference = (1 / 3m * 100) - percentage;
        Assert.Less(difference, 0.01);
    }
}