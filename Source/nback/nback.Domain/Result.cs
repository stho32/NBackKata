namespace nback.Domain;

public record Result<T>(bool IsSuccess, T Value, string Message);