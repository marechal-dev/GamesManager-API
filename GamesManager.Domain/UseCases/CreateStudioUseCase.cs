using GamesManager.Domain.Core;
using GamesManager.Domain.Entities;
using GamesManager.Domain.Repositories;
using GamesManager.Domain.UseCases.Requests;

namespace GamesManager.Domain.UseCases;

public class CreateStudioUseCase
{
    private readonly IStudiosRepository _repository;

    public CreateStudioUseCase(IStudiosRepository repository)
    {
        _repository = repository;
    }

    public async Task<Result<Studio>> Execute(CreateStudioRequest request)
    {
        Studio studio = new(request.Title,
                            request.CurrentNumberOfEmployees,
                            request.OpeningDate);

        try
        {
            await _repository.Create(studio);
        }
        catch (Exception ex)
        {
            return Result<Studio>.Failure(new DomainException(ex.Message));
        }

        return Result<Studio>.Success(studio);
    }
}
