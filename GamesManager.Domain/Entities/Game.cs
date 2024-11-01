using GamesManager.Domain.Core;

namespace GamesManager.Domain.Entities;

public class Game : Entity
{
    public string Title { get; set; }
    public string Description { get; set; }
    public DateTime LaunchDate { get; set; }
    public Studio DeveloperStudio { get; set; }

    public Game(string title, string description, DateTime launchDate, Studio developerStudio) : base(Guid.NewGuid())
    {
        Title = title;
        Description = description;
        LaunchDate = launchDate;
        DeveloperStudio = developerStudio;
    }

    private Game() { }
}
