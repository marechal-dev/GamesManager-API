using GamesManager.Domain.Core;

namespace GamesManager.Domain.Entities;

public class Studio : Entity
{
    public string Title { get; private set; } = String.Empty;
    public int CurrentNumberOfEmployees { get; private set; }
    public DateTime OpeningDate { get; private set; }
    public List<Game> LaunchedGames { get; private set; } = [];

    public Studio(string title, int currentNumberOfEmployees, DateTime openingDate) : base(Guid.NewGuid())
    {
        Title = title;
        CurrentNumberOfEmployees = currentNumberOfEmployees;
        OpeningDate = openingDate;
    }

    private Studio() { }
}
