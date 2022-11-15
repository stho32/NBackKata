namespace nback.Domain;

public class PercentageCalculator
{
    public decimal? PercentTrue(bool[] values)
    {
        if (values.Length == 0)
            return null;
        
        decimal total = values.Length;
        decimal countTrue = values.Count(x => x);
        decimal percentage = countTrue * 100 / total;

        return percentage;
    }
}