namespace GamesManager.Domain.UseCases.Requests;

public record CreateStudioRequest(string Title, int CurrentNumberOfEmployees, DateTime OpeningDate)
{
}
