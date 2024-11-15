using Devpira.Domain._Shared.Abstractions;

namespace Devpira.Domain.Events;

public class Event : BaseEntity
{
    public required string Name { get; init; }
    public required string ShortDescription { get; init; }
    public required string LongDescription { get; init; }
    public required DateTime DateTime { get; init; }
    public string? Place { get; init; }
    public string? Url { get; init; }
    public string? OtherInfo { get; init; }
    public ICollection<Track> Tracks { get; init; }
    public string? VideoUrl { get; init; }
    public ICollection<string> PhotoUrls { get; init; }
    public ICollection<Partner> Partners { get; init; }
}

public class Track : BaseEntity
{
    public string? Name { get; init; }
    public ICollection<Talk> Talks { get; init; }
}

public class Talk : BaseEntity
{
    public string? Name { get; init; }
    public DateTime? DateTime { get; init; }
    public Speaker Speaker { get; init; }
}

public class Speaker : BaseEntity
{
    public required string Name { get; init; }
    public string? PictureUrl { get; init; }
    public string? CompanyName { get; init; }
    public string? JobPosition { get; init; }
}

public class Partner : BaseEntity
{
    public required string Name { get; init; }
    public required string LogoUrl { get; init; }
    public string? WebsiteUrl { get; init; }
    public string? PartnershipCategory { get; init; }
}