namespace GamesManager.Domain.Core;

public class Result<TResultPayload>
{
    private readonly TResultPayload? _payload;
    private readonly DomainException? _exception;

    private Result(TResultPayload payload)
    {
        _payload = payload;
    }

    private Result(DomainException exception)
    {
        _exception = exception;
    }

    public static Result<TResultPayload> Success(TResultPayload payload)
    {
        return new Result<TResultPayload>(payload);
    }

    public static Result<TResultPayload> Failure(DomainException exception)
    {
        return new Result<TResultPayload>(exception);
    }

    public bool IsSuccess()
    {
        return _payload is not null;
    }

    public bool IsFailure()
    {
        return _exception is not null;
    }
}
