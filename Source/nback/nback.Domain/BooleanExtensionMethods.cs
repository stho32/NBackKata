namespace nback.Domain.Tests;

public static class BooleanExtensionMethods
{
    public static string ToHumanReadableString(this bool[] values, string trueValue, string falseValue)
    {
        var result = values.Select(x => x ? trueValue : falseValue)
            .ToArray();

        var asString = string.Join("", result);

        return asString;
    }
}