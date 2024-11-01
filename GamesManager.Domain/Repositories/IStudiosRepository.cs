using GamesManager.Domain.Entities;

namespace GamesManager.Domain.Repositories;

public interface IStudiosRepository
{
    Task<bool> Create(Studio studio);
}
