using Ardalis.Specification;

namespace Devpira.Domain._Shared.Abstractions;

public abstract class BaseEntity: IEntity<int>
{
    public int Id { get; set; }
}