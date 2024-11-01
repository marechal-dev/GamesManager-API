namespace GamesManager.Domain.Core;

public abstract class Entity : IEquatable<Entity>
{
    public Guid ID { get; private init; }

    protected Entity(Guid id) => ID = id;

    protected Entity() {}

    public static bool operator ==(Entity a, Entity b)
    {
        if (a is null || b is null)
        {
            return false;
        }

        return a.Equals(b);
    }

    public static bool operator !=(Entity a, Entity b)
    {
        if (a is null || b is null)
        {
            return true;
        }

        return !a.Equals(b);
    }

    public bool Equals(Entity? other)
    {
        if (other is null)
        {
            return false;
        }

        return ReferenceEquals(this, other) || ID == other.ID;
    }

    public override bool Equals(object? obj)
    {
        if (obj is null)
        {
            return false;
        }

        if (ReferenceEquals(this, obj))
        {
            return true;
        }

        if (obj.GetType() != GetType())
        {
            return false;
        }

        if (obj is not Entity other)
        {
            return false;
        }

        if (ID == Guid.Empty || other.ID == Guid.Empty)
        {
            return false;
        }

        return ID == other.ID;
    }

    public override int GetHashCode() => ID.GetHashCode() * 41;
}
